﻿namespace Microsoft.VisualStudio.Composition.AppDomainTests2
{
    using System;
    using System.Collections.Generic;
    using System.Composition;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Export("AnExportWithMetadataTypeValue")]
    [ExportMetadata("SomeType", typeof(YetAnotherExport))]
    public class AnExportWithMetadataTypeValue
    {
    }
}