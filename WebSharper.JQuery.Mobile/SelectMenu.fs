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

/// See Components / Form Elements / Select menus.
module WebSharper.JQuery.Mobile.SelectMenu

open WebSharper.InterfaceGenerator
open WebSharper.JQuery

let SelectMenuConfig =
    Pattern.ConfigObs "SelectMenuConfig" {
        Required = []
        Optional =
            [
                "create", T<Events.JEvent * JQuery -> unit>

                "closeText", T<string>
                "corners", T<bool>
                "defaults", T<bool>
                "disabled", T<bool>
                "dividerTheme", Common.SwatchLetter.Type
                "hidePlaceholderMenuItems", T<bool>
                "icon", Common.Icon.Type
                "iconpos", Common.IconPosition.Type
                "inline", T<bool>
                "mini", T<bool>
                "nativeMenu", T<bool>
                "overlayTheme", Common.SwatchLetter.Type
                "preventFocusZoom", T<bool>
                "shadow", T<bool>
                "theme", Common.SwatchLetter.Type
            ]
        Obsolete =
            [
                "initSelector", T<string>
                "iconshadow", T<bool>
            ]
    }

let SelectMenu =
    let p = Common.Plugin("selectmenu")
    Class "SelectMenu"
    |+> Static [
            p.DefineConstructor()
            p.DefineConstructor(SelectMenuConfig.Type)
            p.DefineMethod("close")
            p.DefineMethod("destroy")
            p.DefineMethod("disable")
            p.DefineMethod("enable")
            p.DefineMethod("open")
            p.DefineMethod("option", T<string>)
            p.DefineFunc("option", T<obj>)
            p.DefineMethod("option", T<string>, T<obj>)
            p.DefineMethod("option", T<obj>)
            p.DefineMethod("refresh")
            p.DefineMethod("refresh", T<bool>)
        ]
