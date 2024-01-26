
//Coloum 40, Row 30 to 26
turn; //Turn from West to North
for (int i = 0; i < 4; i++) //move 4 cells
{
    move();
}


//Row 26, Coloum 40 to 36
for (int i = 0; i < 3; i++) //Turn 3 times from North to West
{
    turn(); 
}
for (int i = 0; i < 4; i++) //move 4 cells
{
    move();
}


//Row 26 to 25, Row 36 to 35
turn;//Turn from West to North
move;
for (int i = 0; i < 3; i++) //Turn 3 times from North to West
{
    turn();
}
move;


//Column 35, Row 25 to 22 
turn;
for (int i = 0; i < 3; i++) //Move 3 cells
{
    move();
}


//Row 22, Column 35 to 34
for (int i = 0; i < 3; i++) //Turn 3 times from North to West
{
    turn();
}
move;


//Column 34, Row 22 to 17
for (int i = 0; i < 5; i++) //Move 5 cells
{
    move();
}


//Row 17, Column 34 to 31
for (int i = 0; i < 3; i++) //Turn 3 times from North to West
{
    turn();
}
for (int i = 0; i < 3; i++) //Move 3 cells
{
    move();
}


//Column 31, Row 17 to 12
turn;//Turn from West to North
move;
for (int i = 0; i < 3; i++) //Turn 3 times from North to West
{
    turn();
}
move;
turn;//Turn from West to North
move;
move;
turn;//Trun from North to East
move;
for (int i = 0; i < 3; i++) //Turn 3 times from East to North
{
    turn();
}
move;
move;


//Row 12, Column 31 to 26
for (int i = 0; i < 3; i++) //Turn 3 times from North to West
{
    turn();
}
for (int i = 0; i < 5; i++) //Move 5 cells
{
    move();
}


//Column 26 to 25, Row 12 to 9
turn;//Turn from West to North
move;
for (int i = 0; i < ; i++) //Turn 3 times from North to West
{
    turn();
}
move
turn//Turn from West to North
move;
move;


//Row 9, Column 25 to 22
for (int i = 0; i < 3; i++) //Turn 3 times from North to West
{
    turn();
}
for (int i = 0; i < 3; i++) //Move 3 cells
{
    move();
}


//Column 22 to 21, Row 9 to 4
turn;//Turn from West to North
for (int i = 0; i < 3; i++) //Move 3 cells
{
    move();
}


//Row 4, Column 21  to 18
for (int i = 0; i < 3; i++) //Turn 3 times from North to West
{
    turn();
}
for (int i = 0; i < 3; i++) //Move 3 cells
{
    move();
}

//Column 18, Row 4 to 7
for (int i = 0; i < 3; i++) //Turn 3 times from West to South
{
    turn();
}
for (int i = 0; i < 3; i++) //Move 3 cells
{
    move();
}


//Row 7 to 6, Column 18 to 9
turn;//From South to West
for (int i = 0; i < 5; i++) //Move 5 cells
{
    move();
}
turn;//From West to north
move;
for (int i = 0; i < 3; i++) //Turn 3 times from North to West
{
    turn();
}
for (int i = 0; i < 4; i++) //Move 4 cells
{
    move();
}


//Row 6 to 4, Column 9 to 6
turn;//From West to North
move;
for (int i = 0; i < 3; i++) //Turn 3 times from North to West
{
    turn();
}
move;
turn;//From West to north
move;
for (int i = 0; i < 3; i++) //Turn 3 times from North to West
{
    turn();
}
move;
move;


//Row 4 to 1, Column 6 to 2
turn;
move;
for (int i = 0; i < 3; i++) //Turn 3 times from North to West
{
    turn();
}
for (int i = 0; i < 4; i++) //Move 4 cells
{
    move();
}
turn;//From West to North
for (int i = 0; i < 2; i++) //Move 2 cells
{
    move();
}
AtGoal;
