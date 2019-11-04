using System;
using System.Xml.Serialization;
using USC.GISResearchLab.Common.Addresses;
using USC.GISResearchLab.Common.Core.Geographics.Features.Interfaces;
using USC.GISResearchLab.Common.GeographicFeatures.Streets;
using USC.GISResearchLab.Common.Geometries;
using USC.GISResearchLab.Geocoding.Core.Metadata.ReferenceSources;

namespace USC.GISResearchLab.Geocoding.Core.ReferenceDatasets.ReferenceFeatures
{

    public enum ReferenceFeatureType { Dime, Nickle, Penny }

    public abstract class AbstractReferenceFeature : IReferenceFeature
    {
        #region Properties

        public AddressComponents AddressComponent { get; set; }
        public ReferenceFeatureType ReferenceFeatureType { get; set; }
        public ReferenceSourceType ReferenceSourceType { get; set; }
        public Geometry Geometry { get; set; }
        public Geometry GeometrySource { get; set; }
        public string PrimaryId { get; set; }
        public string SecondaryId { get; set; }
        public bool IsValidCandidate { get; set; }
        public IStreetAddressableGeographicFeature StreetAddressableGeographicFeature { get; set; }

        public string Error { get; set; }
        public bool ExceptionOccurred { get; set; }

        [XmlIgnore]
        public Exception Exception { get; set; }

        #endregion

        public AbstractReferenceFeature()
        {
            // use the nickle street as the default
            StreetAddressableGeographicFeature = new NickleStreet();
        }

    }
}
