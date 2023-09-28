using enum_extension_and_pattern_matching;
// enum extension
// pattern matching

Move myMove = Move.Paper;
Move otherMove = Move.Rock;


Outcome result = myMove.CheckOutcome(otherMove);
Outcome result2 = otherMove.CheckOutcome(otherMove);
int newpoint = myMove.OffsetPoints(8);

Console.WriteLine(result);
Console.WriteLine(myMove.GetPoints());
Console.WriteLine(otherMove.GetPoints());