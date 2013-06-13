namespace Fs
    type IName =
        abstract member LastName:string
        abstract member FirstName:string

    type Name = {LastName:string; FirstName:string}
                override x.ToString() = sprintf "%A" x
                interface IName with  
                    member x.LastName = sprintf "%s from interface" x.LastName 
                    member x.FirstName = sprintf "%s from interface" x.FirstName

            
    module TestModule =
        let t = {new IName with 
                    member x.LastName = "A random name"    
                    member x.FirstName = "More randomness"
                }
