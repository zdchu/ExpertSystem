using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expertsystem
{
    class RowFact
    {
        private List<string> Is = null;
        public RowFact(List<string> Is)
        {
            this.Is = Is;
        }
        public void setLs(List<string> Is)
        {
            this.Is = Is;
        }
        public List<string> getLs()
        {
            return this.Is;
        }
    }

    public partial class Expert_System : Form
    {
        private string data_path = Environment.CurrentDirectory + "\\rule.txt";
        private Dictionary<RowFact, string> dict_result = new Dictionary<RowFact, string>();
        private string new_rules = "";
        private bool updated = false;

        public Expert_System()
        {
            InitializeComponent();
            Parse(FileUtils.read_data(data_path));
        }

        public void Set_Newrules(string str)
        {
            new_rules = str;
            updated = true;
        }

        private void button_Ontology_Click(object sender, EventArgs e)
        {
            var frm = new Ontology_Add();
            frm.ShowDialog(this);
        }

        private Dictionary<RowFact, string> Parse(string text)
        {
            var array_facts = text.Split(Environment.NewLine.ToCharArray());
            // var dic_result = new Dictionary<RowFact, string>();
            for (int i=0; i < array_facts.Length; i++)
            { 
                var fact_items = array_facts[i].Split("".ToCharArray());
                if (fact_items.Length == 1)
                {
                    continue;
                }
                var row_fact_list = new List<string>();
                for (int j=0; j < fact_items.Length; j++)
                {
                    if (j==fact_items.Length - 1)
                    {
                        var row_fact = new RowFact(row_fact_list);
                        dict_result.Add(row_fact, fact_items[j]);
                    }
                    else
                    {
                        row_fact_list.Add(fact_items[j]);
                    }
                }
            }
            return dict_result;
        }

        private void Reasoning(List<string> features, Dictionary<RowFact, string> dict)
        {

            foreach(KeyValuePair<RowFact, string> pair in dict)
            {
                if (list_contains_list(pair.Key.getLs(), features))
                {
                    foreach (var item in pair.Key.getLs())
                    {
                        if(features.Contains(item))
                        {
                            features.Remove(item);
                            textBox_Result.AppendText(item + "->");
                        }
                    }
                    if (!features.Contains(pair.Value))
                    {
                        features.Add(pair.Value);
                        textBox_Result.AppendText(pair.Value);
                        textBox_Result.AppendText("\n");
                    }
                }
            }
            var temp_item = features[features.Count - 1];
            foreach (var item in dict.Values)
            {
                if (item == temp_item)
                {
                    //label_Result.Text = item;
                    MessageBox.Show(item, "推理结果");
                    return;
                }
            }
            MessageBox.Show("无法推理", "推理结果");
        }

        private bool list_contains_list(List<string> list1, List<string> list2)
        {
            bool is_contains = true;
            if (list1.Count > list2.Count)
            {
                foreach(var item in list2)
                {
                    if (!list1.Contains(item))
                    {
                        is_contains = false;
                        return is_contains;
                    }
                }
            }
            else
            {
                foreach(var item in list1)
                {
                    if(!list2.Contains(item))
                    {
                        is_contains = false;
                        return is_contains;
                    }
                }
            }
            return is_contains;
        }
        private void button_Reasoning_Click(object sender, EventArgs e)
        {
            var input_features = textBox_Input.Text.Split(Environment.NewLine.ToCharArray());
            textBox_Result.Clear();
            if (updated)
            {
                Parse(new_rules);
                updated = false;
            }
            Reasoning(input_features.ToList<string>(), dict_result);
        }
    }
}
