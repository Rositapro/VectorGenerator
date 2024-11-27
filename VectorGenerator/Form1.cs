namespace VectorGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVectorGenerator_Click(object sender, EventArgs e)
        {
            int size;
            if (int.TryParse(txtVectorSize.Text, out size))
            {
                if (size <= 0)
                {
                    MessageBox.Show("Vector size must be greater than 0.");
                    return;
                }
                int[] vector = GenerarVector(size);
                txtVector.Text = string.Join(", ", vector);
            }
            else
            {
                MessageBox.Show("Please enter a valid number for size.");
            }
        }

        private int[] GenerarVector(int size)
        {
            Random random = new Random();
            int[] vector = new int[size];

            for (int i = 0; i < size; i++)
            {
                vector[i] = random.Next(1, 101); 
            }
            return vector;
        }
    }
}
