using System.Linq;
using System.Collections.Generic;

namespace Ronnahcate.Homework
{
    public class Container
    {
        public static int GetContainerSize( List<int> blockHeights) {
            int totalContain = 0;
            int startingEdge = 0;
            int blockContain = 0;
            if( blockHeights.Count > 0 ) {
                //looping input block, reverse to make remove command work while looping
               foreach( var height in blockHeights.Reverse<int>()  ) {
                   blockHeights.Remove(height);
                   //get max height left
                   var maxHeigthLeft  = blockHeights.OrderByDescending( h => h).FirstOrDefault();
                   if( height >= startingEdge ) {
                        // sum current section in to total
                        totalContain = totalContain + blockContain;
                        //clear section , prepare for new section
                        blockContain = 0;
                        //define edge for sction
                        if( height <= maxHeigthLeft ) {
                             startingEdge = height;
                        }
                        else {
                            startingEdge = maxHeigthLeft;
                        }
                   }
                   else {
                       // add block in currect section
                       blockContain =  blockContain +( startingEdge - height);  
                   }
               }
               return totalContain;
            }
            else {
                return 0;
            }
        }
    }
}