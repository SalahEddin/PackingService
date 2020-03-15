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

type WeatherCondition = 
    { SkyCondition: SkyCondition
      RainCondition: RainCondition 
      WindCondition: WindCondition
      Temperature: int
      IsTemperatureInCelsius: bool
    }

[<CLIMutable>]
type Shelter =
    { ShelterName: string
      Aliases: string array
      AppropriateCondition: SkyCondition * RainCondition * WindCondition }

[<CLIMutable>]
type Shelters =
    { Shelters: Shelter array }

