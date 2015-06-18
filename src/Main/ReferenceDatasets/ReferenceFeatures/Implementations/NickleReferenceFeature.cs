using USC.GISResearchLab.Common.Geometries.Lines;

namespace USC.GISResearchLab.Geocoding.Core.ReferenceDatasets.ReferenceFeatures.Implementations
{
    public class NickleReferenceFeature : AbstractLinearReferenceFeature
    {
        public NickleReferenceFeature()
        {
            this.ReferenceFeatureType = ReferenceFeatureType.Nickle;
            Geometry = new Line();
        }
    }
}
