namespace USC.GISResearchLab.Geocoding.Core.ReferenceDatasets.ReferenceFeatures
{
    public interface ILinearReferenceFeature : IReferenceFeature
    {
        #region Properties

        bool IsWithinRange { get; set; }

        #endregion

    }
}
