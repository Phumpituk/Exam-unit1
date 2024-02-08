
//Row 8, Colummn 11 to 8
    for (int i = 0; i < 3; i++) //move 3 cells
    {
        move();
    }
turn;//turn 90 degree to North

//In Column8, Row 8 to 6
move;//Move 1 cell
move;//Move 1 cell
turn;//Turn to East

//Row 6, Colummn 8 to 13
    for (int i = 0; i < 5; i++) //move 5 cells
    {
        move();
    }
turn; //Turn from East to South

//In Column 13, Row 6 to 10
    for (int i = 0; i < 4; i++) //move 4 cells
    {
        move();
    }
turn;//Turn from South to West

//Row 10, Column 13 to 6
    for (int i = 0; i < 7; i++) //move 7 cells
    {
        move();
    }
turn;//turn from West to North

//Column 6, Row 10 to 4
    for (int i = 0; i < 6; i++) //move 6 cells
    {
        move();
    }
turn; // Turn from North to East

//
//Row 4, Colummn 6 to 15
    for (int i = 0; i < 9; i++) //move 9 cells
    {
        move();
    }
turn; //Turn from East to South

//In Column 15, Row 4 to 12
    for (int i = 0; i < 8; i++) //move 8 cells
    {
        move();
    }
turn;//Turn from South to West

//Row 12, Column 15 to 4
    for (int i = 0; i < 11; i++) //move 11 cells
    {
        move();
    }
turn;//turn from West to North

//Column 4, Row 12 to 2
    for (int i = 0; i < 10; i++) //move 10 cells
    {
        move();
    }
turn; // Turn from North to East

///
//Row 2, Colummn 4 to 17
    for (int i = 0; i < 13; i++) //move 13 cells
    {
        move();
    }
turn; //Turn from East to South

//In Column 17, Row 2 to 14
    for (int i = 0; i < 12; i++) //move 12 cells
    {
        move();
    }
turn;//Turn from South to West

//Row 14, Column 17 to 2
    for (int i = 0; i < 15; i++) //move 15 cells
    {
        move();
    }
turn;//turn from West to North

//Column 2, Row 14 to 1
    for (int i = 0; i < 13; i++) //move 13 cells
    {
        move();
    }
AtGoal;
