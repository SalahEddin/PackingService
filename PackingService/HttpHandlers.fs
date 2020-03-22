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
                let cond: SkyCondition * RainCondition * WindCondition * HeatLevel = (Sunny, Dry, Still, Hot)
                let response = [| { Shelter = ConditionsHelper.filterShelter cond } |]
                return! json response next ctx
            }

    let handleShelter =
        fun (next: HttpFunc) (ctx: HttpContext) ->
            task {
                // Binds a JSON payload to a Car object
                let! cond = ctx.BindJsonAsync<WeatherCondition>()
                let shelter = ConditionsHelper.filterShelter((cond.SkyCondition, cond.RainCondition, cond.WindCondition, cond.HeatLevel))
                // Sends the object back to the client
                return! Successful.OK shelter next ctx }

    let handleClothing =
        fun (next: HttpFunc) (ctx: HttpContext) ->
            task {
                // Binds a JSON payload to a Car object
                let! cond = ctx.BindJsonAsync<WeatherCondition>()
                let conditions = (cond.SkyCondition, cond.RainCondition, cond.WindCondition, cond.HeatLevel)
                let clothing = {
                    Headwear= ConditionsHelper.filterHeadWear conditions
                    Pants= ConditionsHelper.filterPants conditions
                    Outwear= ConditionsHelper.filterOutwear conditions
                    BaseLayerPants= ConditionsHelper.filterBaseLayerPants conditions
                    Handwear= ConditionsHelper.filterHandwear conditions
                    EyeWear= ConditionsHelper.filterEyewear conditions
                    Jacket= ConditionsHelper.filterJacket conditions
                    Socks= ConditionsHelper.filterSocks conditions
                }
                // Sends the object back to the client
                return! Successful.OK clothing next ctx }
