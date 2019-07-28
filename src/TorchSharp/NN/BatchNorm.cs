using System;
using System.Collections.Generic;
using System.Text;
using TorchSharp.Tensor;

namespace TorchSharp.NN
{
    class BatchNorm : Module
    {
        int num_features;
        double eps;
        double momentum;
        bool affine;
        bool track_running_stats;

        public BatchNorm(int num_features, double eps = 1e-5, double momentum = 0.1, bool affine = true, bool track_running_stats = true) : base()
        {
            this.num_features = num_features;
            this.eps = eps;
            this.momentum = momentum;
            this.affine = affine;
            this.track_running_stats = track_running_stats;

            if (this.affine)
            {

            }
        }

        public override TorchTensor Forward(TorchTensor input)
        {
            throw new NotImplementedException();
        }
    }
}
