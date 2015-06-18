using System;
using USC.GISResearchLab.Common.Addresses;
using USC.GISResearchLab.Common.Core.Geographics.Features.Interfaces;
using USC.GISResearchLab.Geocoding.Core.Metadata.ReferenceSources;

namespace USC.GISResearchLab.Geocoding.Core.ReferenceDatasets.ReferenceFeatures
{
    public interface IReferenceFeature
    {
        #region Properties

        ReferenceFeatureType ReferenceFeatureType { get; set; }
        //Geometry Geometry { get; set; }
        bool IsValidCandidate { get; set; }
        string PrimaryId { get; set; }
        string SecondaryId { get; set; }
        IStreetAddressableGeographicFeature StreetAddressableGeographicFeature { get; set; }
        AddressComponents AddressComponent { get; set; }
        ReferenceSourceType ReferenceSourceType { get; set; }

        string Error { get; set; }
        bool ExceptionOccurred { get; set; }
        Exception Exception { get; set; }


        #endregion
    }
}