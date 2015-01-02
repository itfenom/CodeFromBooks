#ifndef MAZEBUILDER_H
#define MAZEBUILDER_H

#include "Maze.h"

class MazeBuilder
{
	public:
		virtual void BuildMaze();
		virtual void BuildRoom(int room);
		virtual void BuildDoor(int roomFrom, int roomTo);
		
		virtual Maze *GetMaze();

	protected:
		MazeBuilder();
};
#endif // !MAZEBUILDER_H
