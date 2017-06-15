module Navbar.View

open Fable.Helpers.React
open Fable.Helpers.React.Props

let navButton classy href faClass txt =
    div [ ClassName "control" ]
        [ a [ ClassName (sprintf "button %s" classy)
              Href href ]
            [ span [ ClassName "icon" ]
                   [ i [ ClassName (sprintf "fa %s" faClass) ] [] ]
              span [] [ str txt ] ] ]

let navButtons =
    span
        [ ClassName "nav-item block" ]
        [ navButton "twitter" "https://twitter.com/FableCompiler" "fa-twitter" "Twitter"
          navButton "github" "https://github.com/MangelMaxime/Fable.Elmish.Bulma/" "fa-github" "Github"
          navButton "github" "https://gitter.im/fable-compiler/Fable" "fa-comments" "Gitter" ]

let root =
    div [ ClassName "nav" ]
        [ div [ ClassName "nav-left" ]
              [ h1 [ ClassName "nav-item is-brand title is-4" ]
                   [ img  [ Src "logo.png"
                            Alt "logo"
                            Style [ MarginRight "10px" ] ]
                     str "Fable.Elmish.Bulma" ] ]
          navButtons ]
