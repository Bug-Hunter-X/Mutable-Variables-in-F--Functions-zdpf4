let mutable x = 10
let mutable y = 20

let add x y = x + y

let z = add x y
printf "%d\n" z

x <- 15
y <- 25

let z2 = add x y
printf "%d\n" z2