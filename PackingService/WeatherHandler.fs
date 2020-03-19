namespace PackingService

module PackingHelper =
    
   type SkyCondition = Sunny | Cloudy
   type RainCondition = Dry | Rain | Snow | Hail
   type WindCondition = Still | Wind | ExtremeWind
   type HeatLevel = ExtremelyHot | Hot | Warm | Cold | Freezing

   type Shelter = Hammock | Tent | GeodesicTent
   type Headwear = Hat | Beanie | None
   type Pants = Pants | Shorts | None
   type Outwear = Fleece | Sweater | None
   type BaseLayerPants = Leggins | None
   type Handwear = Gloves | None
   type EyeWear = Sunglasses | None
   type Jacket = RainJacket | Windstopper | None
   type Socks = Regular | Wool

   type WeatherCondition = 
       { SkyCondition: SkyCondition
         RainCondition: RainCondition 
         WindCondition: WindCondition
         Temperature: int
         IsTemperatureInCelsius: bool }
    
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

    let filterPants = Pants
    let filterOutwear = Fleece
    let filterBaseLayerPants = Leggins
    let filterHandwear = Gloves
    let filterEyewear = Sunglasses
    let filterJacket = RainJacket
    let filterSocks = Wool

    //let squaresOfOdds xs =
    //    xs
    //    |> Seq.filter isOdd
    //    |> Seq.map square