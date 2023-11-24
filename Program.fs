type Coach = {
    Name: string
    FormerPlayer: bool
}

type Stats = {
    Wins: int
    Losses: int
}

type Team = {
    Name: string
    Coach: Coach
    Stats: Stats
}

let teams : Team list = [
    { Name = "Chicago Bulls"; Coach = { Name = "Billy Donovan"; FormerPlayer = true }; Stats = { Wins = 2344; Losses = 2254 } }
    { Name = "Indiana Pacers"; Coach = { Name = "Rick Carlisle"; FormerPlayer = false }; Stats = { Wins = 2340; Losses = 2103 } }
    { Name = "Los Angeles Lakers"; Coach = { Name = "Frank Vogel"; FormerPlayer = false }; Stats = { Wins = 2400; Losses = 2200 } }
    { Name = "Miami Heat"; Coach = { Name = "Erik Spoelstra"; FormerPlayer = true }; Stats = { Wins = 2300; Losses = 2000 } }
    { Name = "Toronto Raptors"; Coach = { Name = "Darko Rajakovic"; FormerPlayer = true }; Stats = { Wins = 1071; Losses = 1157 } }
]

let success =
    teams
    |> List.filter (fun team -> team.Stats.Wins > team.Stats.Losses)
    |> List.map (fun team -> team.Name)

printfn "Successful Teams: %A" success


let cal team =
    float team.Stats.Wins / float (team.Stats.Wins + team.Stats.Losses) * 100.0

let percentage =
    teams
    |> List.map (fun team -> (team.Name, cal team))

printfn "Success Percentages: %A" percentage
