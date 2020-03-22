namespace PackingService

module PackingHelper =
    open PackingService.Models
   
    let filterShelter conditions = 
        match conditions with
        | (Sunny, Dry, _,ExtremelyHot) -> Hammock
        | (Sunny, Dry, _,Hot) -> Hammock
        | (_, Hail, ExtremeWind, Cold) -> GeodesicTent
        | (_, Hail, ExtremeWind, Freezing) -> GeodesicTent
        | (_, Hail, Wind, Freezing) -> GeodesicTent
        | (_, _, _, _) -> Tent

    let filterHeadWear conditions = 
        match conditions with
        | (_, Dry, _, _) -> Headwear.None
        | (Sunny, _, _, _) -> Hat
        | (Cloudy, _, _,_) -> Beanie

    let filterPants conditions = Pants
    let filterOutwear conditions = Fleece
    let filterBaseLayerPants conditions = Leggins
    let filterHandwear conditions = Gloves
    let filterEyewear conditions = Sunglasses
    let filterJacket conditions = RainJacket
    let filterSocks conditions = Wool
    