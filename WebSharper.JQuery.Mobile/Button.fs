// $begin{copyright}
//
// This file is part of WebSharper
//
// Copyright (c) 2008-2018 IntelliFactory
//
// Licensed under the Apache License, Version 2.0 (the "License"); you
// may not use this file except in compliance with the License.  You may
// obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or
// implied.  See the License for the specific language governing
// permissions and limitations under the License.
//
// $end{copyright}

/// See Components / Buttons.
module WebSharper.JQuery.Mobile.Button

open WebSharper.InterfaceGenerator
open WebSharper.JQuery

let ButtonConfig =
    Pattern.ConfigObs "ButtonConfig" {
        Required = []
        Optional =
            [
                "create", T<Events.JEvent * JQuery -> unit>

                "corners", T<bool>
                "disabled", T<bool>
                "enhanced", T<bool>
                "icon", Common.Icon.Type
                "iconpos", Common.IconPosition.Type
                "inline", T<bool>
                "mini", T<bool>
                "shadow", T<bool>
                "theme", T<string>
                "wrapperClass", T<string>
            ]
        Obsolete =
            [
                "iconshadow", T<bool>
                "initSelector", T<string>
            ]
    }

let Button =
    let p = Common.Plugin("button")
    Class "Button"
    |+> Static [
            p.DefineConstructor()
            p.DefineConstructor(ButtonConfig.Type)
            
            p.DefineMethod("destroy")
            p.DefineMethod("disable")
            p.DefineMethod("enable")
            p.DefineMethod("option", T<string>)
            p.DefineFunc("option", T<obj>)
            p.DefineMethod("option", T<string>, T<obj>)
            p.DefineMethod("option", T<obj>)
            p.DefineMethod("refresh")
        ]
