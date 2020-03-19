namespace PackingService

module HttpHandlers =

    open Microsoft.AspNetCore.Http
    open FSharp.Control.Tasks.V2.ContextInsensitive
    open Giraffe
    open PackingService.Models

    let handleGetHello =
        fun (next: HttpFunc) (ctx: HttpContext) ->
            task {
                let response = { Text = "Hello world, from Giraffe!" }
                return! json response next ctx
            }


    let handleGetShelters =
        fun (next: HttpFunc) (ctx: HttpContext) ->
            task {
                let cond : SkyCondition * RainCondition * WindCondition * HeatLevel = (Sunny, Dry, Still, Hot)
                let response =
                    [| { Shelter = PackingHelper.filterShelter cond } |]
                return! json response next ctx
            }

    let handleConditions (conditions: WeatherCondition) =
        fun (next: HttpFunc) (ctx: HttpContext) ->
            task {
                let cond : SkyCondition * RainCondition * WindCondition * HeatLevel = 
                    (conditions.SkyCondition, conditions.RainCondition, conditions.WindCondition, conditions.HeatLevel)
                let response =
                    [| { Shelter = PackingHelper.filterShelter cond } |]
                return! json response next ctx
            }