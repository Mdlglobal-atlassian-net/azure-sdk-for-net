// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// AzureWorkload SAP Hana-specific restore.
    /// </summary>
    public partial class AzureWorkloadSAPHanaRestoreRequest : AzureWorkloadRestoreRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureWorkloadSAPHanaRestoreRequest class.
        /// </summary>
        public AzureWorkloadSAPHanaRestoreRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureWorkloadSAPHanaRestoreRequest class.
        /// </summary>
        /// <param name="recoveryType">OLR/ALR, RestoreDisks is invalid option.
        /// Possible values include: 'Invalid', 'OriginalLocation',
        /// 'AlternateLocation', 'RestoreDisks'</param>
        /// <param name="sourceResourceId">Fully qualified ARM ID of the VM on
        /// which workload that was running is being recovered.</param>
        /// <param name="propertyBag">Workload specific property bag.</param>
        /// <param name="targetInfo">Details of target database</param>
        public AzureWorkloadSAPHanaRestoreRequest(string recoveryType = default(string), string sourceResourceId = default(string), IDictionary<string, string> propertyBag = default(IDictionary<string, string>), TargetRestoreInfo targetInfo = default(TargetRestoreInfo))
            : base(recoveryType, sourceResourceId, propertyBag, targetInfo)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}