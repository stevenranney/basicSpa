namespace basicSpa

open WebSharper
open WebSharper.Html

[<JavaScript>]
module HelloWorld =

    let Main () = 
        let welcome = P [Text "WELCOME!"]
        Div [
            welcome
            Button [Text "Click me!"]
            |>! OnClick (fun e args -> welcome.Text <- "Hello, world!")
            ]

[<SPAEntryPoint>]
let Run() = (Main ()).AppendTo "entrypoint"