namespace DNA_SEQ
{
    public partial class Form1 : Form
    {
        string sequence;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sequence = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Oligo_counter = new Dictionary<string, int>();

            for (int i = 0; i < (sequence.Length - 4); i++)
            {
                string temp = sequence.Substring(i, 4);

                if (Oligo_counter.ContainsKey(temp))
                {
                    Oligo_counter[temp]++;
                }
                else
                {
                    Oligo_counter.Add(temp, 1);
                }
            }

            var items = Oligo_counter.Select(pair => $"{pair.Key} ({pair.Value})").ToList();

            listBox1.DataSource = items;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
