namespace PackingService

module PackingHelper =
    
   type SkyCondition = Sunny | Cloudy
   type RainCondition = Dry | Rain | Snow | Hail
   type WindCondition = Still | Wind | ExtremeWind
   
   type WeatherCondition = 
       { SkyCondition: SkyCondition
         RainCondition: RainCondition 
         WindCondition: WindCondition
         Temperature: int
         IsTemperatureInCelsius: bool }
    
    let filterShelter conditions = 
        match conditions with
        | (Sunny, Dry, _) -> "Hammock"
        | (_, Hail, ExtremeWind) -> "Geodesic Tent"
        | (_, _, _) -> "Tent"


    let private square x = x * x
    let private isOdd x = x % 2 <> 0
    
    let squaresOfOdds xs =
        xs
        |> Seq.filter isOdd
        |> Seq.map square