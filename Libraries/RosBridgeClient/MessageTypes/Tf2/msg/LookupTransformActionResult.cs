/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using RosSharp.RosBridgeClient.MessageTypes.Std;
using RosSharp.RosBridgeClient.MessageTypes.Actionlib;

namespace RosSharp.RosBridgeClient.MessageTypes.Tf2
{
    public class LookupTransformActionResult : Message
    {
        public override string RosMessageName => "tf2_msgs/LookupTransformActionResult";

        //  ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
        public Header header { get; set; }
        public GoalStatus status { get; set; }
        public LookupTransformResult result { get; set; }

        public LookupTransformActionResult()
        {
            this.header = new Header();
            this.status = new GoalStatus();
            this.result = new LookupTransformResult();
        }

        public LookupTransformActionResult(Header header, GoalStatus status, LookupTransformResult result)
        {
            this.header = header;
            this.status = status;
            this.result = result;
        }
    }
}