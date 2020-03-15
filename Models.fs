namespace packwise_api.Models

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

[<CLIMutable>]
type Shelter =
    { ShelterName: string
      Aliases: string array
      AppropriateCondition: string array array }

[<CLIMutable>]
type Shelters =
    { Shelters: Shelter array }
