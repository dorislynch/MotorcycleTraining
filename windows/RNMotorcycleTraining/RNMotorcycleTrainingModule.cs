using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Motorcycle.Training.RNMotorcycleTraining
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNMotorcycleTrainingModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNMotorcycleTrainingModule"/>.
        /// </summary>
        internal RNMotorcycleTrainingModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNMotorcycleTraining";
            }
        }
    }
}
