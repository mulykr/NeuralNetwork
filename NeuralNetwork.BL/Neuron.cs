using System.Collections.Generic;

namespace NeuralNetwork.BL
{
    public class Neuron
    {
        public List<Dendrite> Dendrites { get; set; }

        public Pulse OutputPulse { get; set; }

        public Neuron()
        {
            Dendrites = new List<Dendrite>();
            OutputPulse = new Pulse();
        }

        public void Fire()
        {
            OutputPulse.Value = Sum();

            OutputPulse.Value = Activation(OutputPulse.Value);
        }

        public void UpdateWeights(double newWeights)
        {
            foreach (var terminal in Dendrites)
            {
                terminal.SynapticWeight = newWeights;
            }
        }

        private double Sum()
        {
            double computeValue = 0.0f;
            foreach (var d in Dendrites)
            {
                computeValue += d.InputPulse.Value * d.SynapticWeight;
            }

            return computeValue;
        }

        private double Activation(double input)
        {
            double threshold = 1;
            return input <= threshold ? 0 : threshold;
        }
    }
}
