using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSAndCore.Org
{
    public class Amazon2
    {
        /**
         Amazon plans to open Amazon Go stores downtown in the city of Techlandia. Downtown Techlandia consists of city blocks, 
         represented as a grid of M*N blocks. Each block represents either building denoted by 1 or open land area denoted by 0.

        Adjacent blocks with value 1 are considered clusters of buildings. Diagonal blocks with value 1 are not considered part 
            of the same cluster. Amazon plans to have an Amazon Go store in each cluster of buildings. 
        * */


        /**
         Amazon wants to increase the reliability of their network and is piloting hardware enhancements in one of the data centers prior to a full-scale roll out. To facilitate the routing of the incoming packets, there is a network of N routers in the data center. Every router is connected to every other router of the network either through a direct link or via some other routers.

            To increase the fault tolerance of the network, Amazon wants to identify routers which would result in a disconnected network if they went down and add replicas of these routers to the network. 

            Write an algorithm to identify all such routers that need to be connected to the network all the time.
         */
        public static void Main1()
        {

        }

        public int numberAmazonGoStores(int rows, int column, int[,] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;
            int result = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        result++;
                        doFill(i, j, grid);
                    }
                }
            }
            return result;
        }
        // METHOD SIGNATURE ENDS

        public static void doFill(int row, int col, int[,] matrix)
        {
            if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1) || matrix[row, col] == 0)
            {
                return;
            }
            matrix[row, col] = 0;
            int[] dr = { -1, 0, 1, 0 };
            int[] dc = { 0, 1, 0, -1 };
            for (int i = 0; i < dr.Length; i++)
            {
                doFill(row + dr[i], col + dc[i], matrix);
            }
        }
    }
}
