﻿namespace ResXManager.View.Visuals
{
    using System;

    using JetBrains.Annotations;

    using ResXManager.Infrastructure;

    using TomsToolbox.Composition;
    using TomsToolbox.Wpf.Composition;

    /// <summary>
    /// Interaction logic for CodeReferencesToolTip.xaml
    /// </summary>
    public partial class CodeReferencesToolTip
    {
        public CodeReferencesToolTip([NotNull] IExportProvider exportProvider)
        {
            try
            {
                this.SetExportProvider(exportProvider);

                InitializeComponent();
            }
            catch (Exception ex)
            {
                exportProvider.TraceXamlLoaderError(ex);
            }
        }
    }
}
