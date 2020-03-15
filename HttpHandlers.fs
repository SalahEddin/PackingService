namespace packwise_api

module HttpHandlers =

    open Microsoft.AspNetCore.Http
    open FSharp.Control.Tasks.V2.ContextInsensitive
    open Giraffe
    open packwise_api.Models

    let handleGetHello =
        fun (next: HttpFunc) (ctx: HttpContext) ->
            task {
                let response = { Text = "Hello world, from Giraffe!" }
                return! json response next ctx
            }


    let handleGetShelters =
        fun (next: HttpFunc) (ctx: HttpContext) ->
            task {
                let cond : SkyCondition * RainCondition * WindCondition = (Sunny, Dry, Still)
                let response =
                    [| { ShelterName = "Hello worldz, from Giraffe!"
                         AppropriateCondition = cond
                         Aliases = [| "WOW" |] } |]
                return! json response next ctx
            }
