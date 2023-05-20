namespace Bld.Libnl.Net;

[Flags]
public enum MessageFlags : int
{
    /// <summary>
    /// It is request message
    /// </summary>
    NLM_F_REQUEST = 1,

    /// <summary>
    /// Multipart message, terminated by NLMSG_DONE
    /// </summary>
    NLM_F_MULTI = 2,

    /// <summary>
    /// Reply with ack, with zero or error code
    /// </summary>
    NLM_F_ACK = 4,

    /// <summary>
    /// Echo this request
    /// </summary>
    NLM_F_ECHO = 8,

    /// <summary>
    /// Dump was inconsistent due to sequence change
    /// </summary>
    NLM_F_DUMP_INTR = 16,

    /* Modifiers to GET request */

    /// <summary>
    /// specify tree	root
    /// </summary>
    NLM_F_ROOT = 0x100,

    /// <summary>
    /// return all matching
    /// </summary>
    NLM_F_MATCH = 0x200,

    /// <summary>
    /// atomic GET
    /// </summary>
    NLM_F_ATOMIC = 0x400,

    /// <summary>
    /// NLM_F_ROOT | NLM_F_MATCH
    /// </summary>
    NLM_F_DUMP = (NLM_F_ROOT | NLM_F_MATCH),

    /* Modifiers to NEW request */

    /// <summary>
    /// Override existing
    /// </summary>
    NLM_F_REPLACE = 0x100,

    /// <summary>
    /// Do not touch, if it exists
    /// </summary>
    NLM_F_EXCL = 0x200,

    /// <summary>
    /// Create, if it does not exist
    /// </summary>
    NLM_F_CREATE = 0x400,

    /// <summary>
    /// Add to end of list
    /// </summary>
    NLM_F_APPEND = 0x800,
}