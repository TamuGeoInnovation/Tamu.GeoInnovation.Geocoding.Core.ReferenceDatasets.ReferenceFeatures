namespace USC.GISResearchLab.Geocoding.Core.ReferenceDatasets.ReferenceFeatures
{
    public abstract class AbstractLinearReferenceFeature : AbstractReferenceFeature, ILinearReferenceFeature
    {
        #region Properties

        public bool IsWithinRange { get; set; }


        #endregion

    }
}
