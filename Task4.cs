void MoveUntilExit(char[,] gameBoard, int startRow, int startColumn)
{
    int currentRow = startRow;
    int currentColumn = startColumn;
    int currentDirection = 0;

    while (true)
    {
        int nextDirection = (currentDirection + 90) % 360;

        // Check if the cell to the right is wall, if so, turn clockwise
        if (gameBoard[currentRow, currentColumn + 1] == '1' && gameBoard[currentRow - 1, currentColumn] == '1' && gameBoard[currentRow, currentColumn + 1] == '1')
        {
            currentDirection = (currentDirection + 270) % 360; // Turn clockwise
        }

        if (currentDirection == 0)
        {
            currentRow--;
        }
        else if (currentDirection == 90)
        {
            currentColumn++;
        }
        else if (currentDirection == 180)
        {
            currentRow++;
        }
        else if (currentDirection == 270)
        {
            currentColumn--;
        }

        // Check if the car has exited the maze
        if (currentRow < 0 || currentRow >= gameBoard.GetLength(0) || currentColumn < 0 || currentColumn >= gameBoard.GetLength(1))
        {
            // Car has exited the maze, exit the movement loop
            Atgoal;
        }
    }
}