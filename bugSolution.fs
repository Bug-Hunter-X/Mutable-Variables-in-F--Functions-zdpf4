let x = ref 10
let y = ref 20

let add x y = !x + !y

let z = add x y
printf "%d\n" z // Output: 30

x := 15
y := 25

let z2 = add x y
printf "%d\n" z2 // Output: 40