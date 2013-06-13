namespace Explore
open FSharp.Data
    
    module dataExplorer = 
        let data = FreebaseData.GetDataContext()
        let print () = data.``Arts and Entertainment``.Comics.``Comic Book Colorists`` |> Seq.take 10 |> Seq.iter (fun x -> printf "%A \n" x)
    

