using USC.GISResearchLab.Common.Addresses;

namespace USC.GISResearchLab.Geocoding.Core.ReferenceDatasets.ReferenceFeatures.Implementations
{
    public class PennyReferenceFeature: AbstractReferenceFeature
    {
        #region Properties

        

        #endregion

        public PennyReferenceFeature()
        {
            this.ReferenceFeatureType = ReferenceFeatureType.Penny;
        }

        public PennyReferenceFeature(AddressComponents addressComponents)
            : this()
        {
            AddressComponent = addressComponents;
        }
    }
}