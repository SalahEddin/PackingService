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
                let response =
                    [| { ShelterName = "Hello world, from Giraffe!"
                         AppropriateCondition = [| [| "sunny" |] |]
                         Aliases = [| "WOW" |] } |]
                return! json response next ctx
            }
