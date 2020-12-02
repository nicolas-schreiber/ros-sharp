/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

namespace RosSharp.RosBridgeClient.MessageTypes.Rosapi
{
    public class PublishersResponse : Message
    {
        public override string RosMessageName => "rosapi/Publishers";

        public string[] publishers { get; set; }

        public PublishersResponse()
        {
            this.publishers = new string[0];
        }

        public PublishersResponse(string[] publishers)
        {
            this.publishers = publishers;
        }
    }
}
