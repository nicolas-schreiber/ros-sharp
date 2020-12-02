/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class AllowedCollisionEntry : Message
    {
        public override string RosMessageName => "moveit_msgs/AllowedCollisionEntry";

        //  whether or not collision checking is enabled
        public bool[] enabled { get; set; }

        public AllowedCollisionEntry()
        {
            this.enabled = new bool[0];
        }

        public AllowedCollisionEntry(bool[] enabled)
        {
            this.enabled = enabled;
        }
    }
}
