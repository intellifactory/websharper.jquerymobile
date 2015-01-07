﻿namespace IntelliFactory.WebSharper.JQuery.Mobile.Tests

open IntelliFactory.WebSharper.Html.Server
open IntelliFactory.WebSharper.Sitelets

type Action =
    | App

module Skin =
    open System.IO

    type Page =
        {
            Body : list<Content.HtmlElement>
        }

    let MainTemplate =
        Content.Template<Page>("~/Main.html")
            .With("body", fun x -> x.Body)

    let WithTemplate body : Content<Action> =
        Content.WithTemplate MainTemplate <| fun context ->
            {
                Body =  body context
            }

module Site =
    let App = Skin.WithTemplate <| fun ctx -> [ Div [ new AppControl() ] ]

[<Sealed>]
type Sample() =
    interface IWebsite<Action> with
        member this.Sitelet = Sitelet.Content "/" App Site.App
        member this.Actions = [ App ]

[<assembly: Website(typeof<Sample>)>]
do ()
