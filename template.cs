#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    currentPosition += 1; // Moves the car 1 cell in the direction it is heading. 
}

void Turn()
{
   currentDirection = (currentDirection + 90) % 360; // Turns the car 90 degree clockwise.
}

bool Peek()
{

    int nextRow = currentRow;
    int nextColumn = currentColumn;

    // Update the next cell
    if (currentDirection == 0) //north
        nextRow--;
    else if (currentDirection == 90) //east
        nextColumn++;
    else if (currentDirection == 180) //south
        nextRow++;
    else if (currentDirection == 270) //west
        nextColumn--;

    // Check
    if (nextRow >= 0 && nextRow < gameBoard.GetLength(0) && nextColumn >= 0 && nextColumn < gameBoard.GetLength(1))
    {
        // Check if the next cell is open
        if (gameBoard[nextRow, nextColumn] == 0)
            return true;
    }

    return false;
}

bool AtGoal()
{
    
    if (currentRow >= 0 && currentRow < gameBoard.GetLength(0) && currentColumn >= 0 && currentColumn < gameBoard.GetLength(1))
    {
        // Check if the current cell is the goal cell
        if (gameBoard[currentRow, currentColumn] == 2) // assuming 2 represents the goal cell
            return true;
    }

    // If the current cell is not the goal cell or the current position is out of bounds, return false.
    return false;
}

#endregion