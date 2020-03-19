namespace PackingService.Models

[<CLIMutable>]
type Message =
    { Text: string }

[<CLIMutable>]
type DoubleMessage =
    { Text: string
      OtherText: string
      Aliases: string array }

[<CLIMutable>]
type Messages =
    { Messages: DoubleMessage array }

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

type Activity = Climbing | Hiking

type WeatherCondition = 
    { SkyCondition: SkyCondition
      RainCondition: RainCondition 
      WindCondition: WindCondition
      HeatLevel: HeatLevel
    }

[<CLIMutable>]
type ShelterType = { Shelter: Shelter}

[<CLIMutable>]
type ShelterOption =
    { ShelterName: string
      Aliases: string array
      AppropriateCondition: SkyCondition * RainCondition * WindCondition * HeatLevel }

[<CLIMutable>]
type Shelters =
    { Shelters: Shelter array }

