namespace ConvNetSharp
{
    public sealed class InputLayer : LayerBase
    {
        public InputLayer(int inputWidth, int inputHeight, int inputDepth)
        {
            this.Init(inputWidth, inputHeight, inputDepth);

            this.OutputWidth = inputWidth;
            this.OutputHeight = inputHeight;
            this.OutputDepth = inputDepth;
        }

        public override Volume Forward(Volume volume, bool isTraining = false)
        {
            this.InputActivation = volume;
            this.OutputActivation = volume;
            return this.OutputActivation; // simply identity function for now
        }

        public override void Backward()
        {
        }
    }
}