namespace NeuralNetwork.BL
{
    public class NeuralData
    {
        public double[][] Data { get; set; }

        private int _counter = 0;

        public NeuralData(int rows)
        {
            Data = new double[rows][];
        }

        public void Add(params double[] rec)
        {
            Data[_counter] = rec;
            _counter++;
        }
    }
}
