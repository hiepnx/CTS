using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTS.Domain.Data;
using CTS.Domain.Domain;

namespace CTS.Services.TestItemServices
{
    public interface ITestItemService
    {
        /// <summary>
        /// Gets or sets the repository.
        /// </summary>
        /// <value>The repository.</value>
        IRepository<TestItem> Repository { get; }

        /// <summary>
        /// Gets the testItem with the specified ID.
        /// </summary>
        /// <param name="Id">The testItem id to fetch.</param>
        /// <returns></returns>
        TestItem GetTicket(int Id);

        
        IEnumerable<TestItem> ListTestItems( bool includeComments);
        /// <summary>
        /// Delete the TestItem
        /// </summary>
        /// <param name="Id">Id of the test Item</param>
        /// <returns></returns>
        int? DeleteTestItem(int Id);

        /// <summary>
        /// Creates the new testItem.
        /// </summary>
        /// <param name="testItem">The testItem.</param>
        /// <param name="creatorUserName">User name of the creator.</param>
        /// <param name="creatorDisplayName">Display name of the creator.</param>
        /// <param name="ownerDisplayName">Display name of the owner.</param>
        /// <returns></returns>
        int? CreateNewTestItem(TestItem testItem);

        /// <summary>
        /// Edits the testItem.
        /// </summary>
        /// <param name="testItem">The testItem being edited with updated values.</param>
        /// <param name="comment">The comment.</param>
        /// <returns></returns>
        bool EditTestItemDetails(TestItem testItem, string comment);

        /// <summary>
        /// Adds the comment to testItem
        /// </summary>
        /// <param name="testItem">The testItem.</param>
        /// <param name="comment">The comment content.</param>
        /// <returns></returns>
        bool AddCommentToTestItem(TestItem testItem, string comment);      

        /// <summary>
        /// Modifies the attachments for ticket.
        /// </summary>
        /// <param name="ticket">The ticket.</param>
        /// <param name="comment">The comment.</param>
        /// <param name="attachments">The list attachment files with the desired state of the attachments</param>
        /// <returns></returns>
        bool ModifyAttachmentsForTestItem(TestItem testItem, string comment, List<TestAttachment> attachments);

        /// <summary>
        /// Gets the attachment.
        /// </summary>
        /// <param name="fileId">The file id.</param>
        /// <returns></returns>
        TestAttachment GetAttachment(int fileId);



        /// <summary>
        /// Gets possible suggestions for the last element of an incomplete taglist.
        /// </summary>
        /// <param name="partialTagList"></param>
        /// <param name="maxNumTagsToReturn">The max num tags to return.</param>
        /// <returns></returns>
       // string[] GetTagCompletionList(string partialTagList, int maxNumTagsToReturn);
    }
}
