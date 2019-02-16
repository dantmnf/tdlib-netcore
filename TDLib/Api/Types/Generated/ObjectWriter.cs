using System;

//////////////////////////////////////
//// GENERATED FILE! DO NOT EDIT! ////
//////////////////////////////////////

namespace TDLib.Api.Types
{
    public partial class TLObject
    {
        internal void TdJsonWriteExtra(TdJsonWriter writer)
        {
            if (this.Extra != null)
            {
                writer.WriteSpan(StringPool.Slice(0, 10)); // ,"@extra":
                writer.WriteValue(this.Extra);
            }
        }
    }
    public partial class Error
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16, 16)); // {"@type":"error"
            writer.WriteSpan(StringPool.Slice(32, 8)); // ,"code":
            writer.WriteValue(this.code);
            writer.WriteSpan(StringPool.Slice(40, 11)); // ,"message":
            writer.WriteValue(this.message);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Ok
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(56, 13)); // {"@type":"ok"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TdlibParameters
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(72, 26)); // {"@type":"tdlibParameters"
            writer.WriteSpan(StringPool.Slice(104, 15)); // ,"use_test_dc":
            writer.WriteValue(this.use_test_dc);
            writer.WriteSpan(StringPool.Slice(120, 22)); // ,"database_directory":
            writer.WriteValue(this.database_directory);
            writer.WriteSpan(StringPool.Slice(144, 19)); // ,"files_directory":
            writer.WriteValue(this.files_directory);
            writer.WriteSpan(StringPool.Slice(168, 21)); // ,"use_file_database":
            writer.WriteValue(this.use_file_database);
            writer.WriteSpan(StringPool.Slice(192, 26)); // ,"use_chat_info_database":
            writer.WriteValue(this.use_chat_info_database);
            writer.WriteSpan(StringPool.Slice(224, 24)); // ,"use_message_database":
            writer.WriteValue(this.use_message_database);
            writer.WriteSpan(StringPool.Slice(248, 20)); // ,"use_secret_chats":
            writer.WriteValue(this.use_secret_chats);
            writer.WriteSpan(StringPool.Slice(272, 10)); // ,"api_id":
            writer.WriteValue(this.api_id);
            writer.WriteSpan(StringPool.Slice(288, 12)); // ,"api_hash":
            writer.WriteValue(this.api_hash);
            writer.WriteSpan(StringPool.Slice(304, 24)); // ,"system_language_code":
            writer.WriteValue(this.system_language_code);
            writer.WriteSpan(StringPool.Slice(328, 16)); // ,"device_model":
            writer.WriteValue(this.device_model);
            writer.WriteSpan(StringPool.Slice(344, 18)); // ,"system_version":
            writer.WriteValue(this.system_version);
            writer.WriteSpan(StringPool.Slice(368, 23)); // ,"application_version":
            writer.WriteValue(this.application_version);
            writer.WriteSpan(StringPool.Slice(392, 28)); // ,"enable_storage_optimizer":
            writer.WriteValue(this.enable_storage_optimizer);
            writer.WriteSpan(StringPool.Slice(424, 21)); // ,"ignore_file_names":
            writer.WriteValue(this.ignore_file_names);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AuthenticationCodeTypeTelegramMessage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(448, 48)); // {"@type":"authenticationCodeTypeTelegramMessage"
            writer.WriteSpan(StringPool.Slice(496, 10)); // ,"length":
            writer.WriteValue(this.length);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AuthenticationCodeTypeSms
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(512, 36)); // {"@type":"authenticationCodeTypeSms"
            writer.WriteSpan(StringPool.Slice(496, 10)); // ,"length":
            writer.WriteValue(this.length);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AuthenticationCodeTypeCall
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(552, 37)); // {"@type":"authenticationCodeTypeCall"
            writer.WriteSpan(StringPool.Slice(496, 10)); // ,"length":
            writer.WriteValue(this.length);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AuthenticationCodeTypeFlashCall
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(592, 42)); // {"@type":"authenticationCodeTypeFlashCall"
            writer.WriteSpan(StringPool.Slice(640, 11)); // ,"pattern":
            writer.WriteValue(this.pattern);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AuthenticationCodeInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(656, 33)); // {"@type":"authenticationCodeInfo"
            writer.WriteSpan(StringPool.Slice(696, 16)); // ,"phone_number":
            writer.WriteValue(this.phone_number);
            if (this.type != null)
            {
                writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
                writer.WriteValue(this.type);
            }
            if (this.next_type != null)
            {
                writer.WriteSpan(StringPool.Slice(720, 13)); // ,"next_type":
                writer.WriteValue(this.next_type);
            }
            writer.WriteSpan(StringPool.Slice(736, 11)); // ,"timeout":
            writer.WriteValue(this.timeout);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class EmailAddressAuthenticationCodeInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(752, 45)); // {"@type":"emailAddressAuthenticationCodeInfo"
            writer.WriteSpan(StringPool.Slice(800, 25)); // ,"email_address_pattern":
            writer.WriteValue(this.email_address_pattern);
            writer.WriteSpan(StringPool.Slice(496, 10)); // ,"length":
            writer.WriteValue(this.length);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TextEntity
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(832, 21)); // {"@type":"textEntity"
            writer.WriteSpan(StringPool.Slice(856, 10)); // ,"offset":
            writer.WriteValue(this.offset);
            writer.WriteSpan(StringPool.Slice(496, 10)); // ,"length":
            writer.WriteValue(this.length);
            if (this.type != null)
            {
                writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
                writer.WriteValue(this.type);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TextEntities
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(872, 23)); // {"@type":"textEntities"
            if (this.entities != null)
            {
                writer.WriteSpan(StringPool.Slice(896, 12)); // ,"entities":
                writer.WriteArray(this.entities);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class FormattedText
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(912, 24)); // {"@type":"formattedText"
            writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
            writer.WriteValue(this.text);
            if (this.entities != null)
            {
                writer.WriteSpan(StringPool.Slice(896, 12)); // ,"entities":
                writer.WriteArray(this.entities);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TermsOfService
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(944, 25)); // {"@type":"termsOfService"
            if (this.text != null)
            {
                writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
                writer.WriteValue(this.text);
            }
            writer.WriteSpan(StringPool.Slice(976, 16)); // ,"min_user_age":
            writer.WriteValue(this.min_user_age);
            writer.WriteSpan(StringPool.Slice(992, 14)); // ,"show_popup":
            writer.WriteValue(this.show_popup);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AuthorizationStateWaitTdlibParameters
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(1008, 48)); // {"@type":"authorizationStateWaitTdlibParameters"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AuthorizationStateWaitEncryptionKey
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(1056, 46)); // {"@type":"authorizationStateWaitEncryptionKey"
            writer.WriteSpan(StringPool.Slice(1104, 16)); // ,"is_encrypted":
            writer.WriteValue(this.is_encrypted);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AuthorizationStateWaitPhoneNumber
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(1120, 44)); // {"@type":"authorizationStateWaitPhoneNumber"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AuthorizationStateWaitCode
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(1168, 37)); // {"@type":"authorizationStateWaitCode"
            writer.WriteSpan(StringPool.Slice(1208, 17)); // ,"is_registered":
            writer.WriteValue(this.is_registered);
            if (this.terms_of_service != null)
            {
                writer.WriteSpan(StringPool.Slice(1232, 20)); // ,"terms_of_service":
                writer.WriteValue(this.terms_of_service);
            }
            if (this.code_info != null)
            {
                writer.WriteSpan(StringPool.Slice(1256, 13)); // ,"code_info":
                writer.WriteValue(this.code_info);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AuthorizationStateWaitPassword
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(1272, 41)); // {"@type":"authorizationStateWaitPassword"
            writer.WriteSpan(StringPool.Slice(1320, 17)); // ,"password_hint":
            writer.WriteValue(this.password_hint);
            writer.WriteSpan(StringPool.Slice(1344, 30)); // ,"has_recovery_email_address":
            writer.WriteValue(this.has_recovery_email_address);
            writer.WriteSpan(StringPool.Slice(1376, 34)); // ,"recovery_email_address_pattern":
            writer.WriteValue(this.recovery_email_address_pattern);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AuthorizationStateReady
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(1416, 34)); // {"@type":"authorizationStateReady"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AuthorizationStateLoggingOut
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(1456, 39)); // {"@type":"authorizationStateLoggingOut"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AuthorizationStateClosing
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(1496, 36)); // {"@type":"authorizationStateClosing"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AuthorizationStateClosed
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(1536, 35)); // {"@type":"authorizationStateClosed"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PasswordState
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(1576, 24)); // {"@type":"passwordState"
            writer.WriteSpan(StringPool.Slice(1600, 16)); // ,"has_password":
            writer.WriteValue(this.has_password);
            writer.WriteSpan(StringPool.Slice(1320, 17)); // ,"password_hint":
            writer.WriteValue(this.password_hint);
            writer.WriteSpan(StringPool.Slice(1344, 30)); // ,"has_recovery_email_address":
            writer.WriteValue(this.has_recovery_email_address);
            writer.WriteSpan(StringPool.Slice(1616, 21)); // ,"has_passport_data":
            writer.WriteValue(this.has_passport_data);
            writer.WriteSpan(StringPool.Slice(1640, 46)); // ,"unconfirmed_recovery_email_address_pattern":
            writer.WriteValue(this.unconfirmed_recovery_email_address_pattern);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RecoveryEmailAddress
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(1688, 31)); // {"@type":"recoveryEmailAddress"
            writer.WriteSpan(StringPool.Slice(1720, 26)); // ,"recovery_email_address":
            writer.WriteValue(this.recovery_email_address);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TemporaryPasswordState
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(1752, 33)); // {"@type":"temporaryPasswordState"
            writer.WriteSpan(StringPool.Slice(1600, 16)); // ,"has_password":
            writer.WriteValue(this.has_password);
            writer.WriteSpan(StringPool.Slice(1792, 13)); // ,"valid_for":
            writer.WriteValue(this.valid_for);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class LocalFile
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(1808, 20)); // {"@type":"localFile"
            writer.WriteSpan(StringPool.Slice(1832, 8)); // ,"path":
            writer.WriteValue(this.path);
            writer.WriteSpan(StringPool.Slice(1840, 21)); // ,"can_be_downloaded":
            writer.WriteValue(this.can_be_downloaded);
            writer.WriteSpan(StringPool.Slice(1864, 18)); // ,"can_be_deleted":
            writer.WriteValue(this.can_be_deleted);
            writer.WriteSpan(StringPool.Slice(1888, 25)); // ,"is_downloading_active":
            writer.WriteValue(this.is_downloading_active);
            writer.WriteSpan(StringPool.Slice(1920, 28)); // ,"is_downloading_completed":
            writer.WriteValue(this.is_downloading_completed);
            writer.WriteSpan(StringPool.Slice(1952, 26)); // ,"downloaded_prefix_size":
            writer.WriteValue(this.downloaded_prefix_size);
            writer.WriteSpan(StringPool.Slice(1984, 19)); // ,"downloaded_size":
            writer.WriteValue(this.downloaded_size);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RemoteFile
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(2008, 21)); // {"@type":"remoteFile"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(2040, 23)); // ,"is_uploading_active":
            writer.WriteValue(this.is_uploading_active);
            writer.WriteSpan(StringPool.Slice(2064, 26)); // ,"is_uploading_completed":
            writer.WriteValue(this.is_uploading_completed);
            writer.WriteSpan(StringPool.Slice(2096, 17)); // ,"uploaded_size":
            writer.WriteValue(this.uploaded_size);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class File
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(2120, 15)); // {"@type":"file"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(2136, 8)); // ,"size":
            writer.WriteValue(this.size);
            writer.WriteSpan(StringPool.Slice(2144, 17)); // ,"expected_size":
            writer.WriteValue(this.expected_size);
            if (this.local != null)
            {
                writer.WriteSpan(StringPool.Slice(2168, 9)); // ,"local":
                writer.WriteValue(this.local);
            }
            if (this.remote != null)
            {
                writer.WriteSpan(StringPool.Slice(2184, 10)); // ,"remote":
                writer.WriteValue(this.remote);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputFileId
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(2200, 22)); // {"@type":"inputFileId"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputFileRemote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(2224, 26)); // {"@type":"inputFileRemote"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputFileLocal
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(2256, 25)); // {"@type":"inputFileLocal"
            writer.WriteSpan(StringPool.Slice(1832, 8)); // ,"path":
            writer.WriteValue(this.path);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputFileGenerated
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(2288, 29)); // {"@type":"inputFileGenerated"
            writer.WriteSpan(StringPool.Slice(2320, 17)); // ,"original_path":
            writer.WriteValue(this.original_path);
            writer.WriteSpan(StringPool.Slice(2344, 14)); // ,"conversion":
            writer.WriteValue(this.conversion);
            writer.WriteSpan(StringPool.Slice(2144, 17)); // ,"expected_size":
            writer.WriteValue(this.expected_size);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PhotoSize
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(2360, 20)); // {"@type":"photoSize"
            writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
            writer.WriteValue(this.type);
            if (this.photo != null)
            {
                writer.WriteSpan(StringPool.Slice(2384, 9)); // ,"photo":
                writer.WriteValue(this.photo);
            }
            writer.WriteSpan(StringPool.Slice(2400, 9)); // ,"width":
            writer.WriteValue(this.width);
            writer.WriteSpan(StringPool.Slice(2416, 10)); // ,"height":
            writer.WriteValue(this.height);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MaskPointForehead
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(2432, 28)); // {"@type":"maskPointForehead"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MaskPointEyes
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(2464, 24)); // {"@type":"maskPointEyes"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MaskPointMouth
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(2488, 25)); // {"@type":"maskPointMouth"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MaskPointChin
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(2520, 24)); // {"@type":"maskPointChin"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MaskPosition
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(2544, 23)); // {"@type":"maskPosition"
            if (this.point != null)
            {
                writer.WriteSpan(StringPool.Slice(2568, 9)); // ,"point":
                writer.WriteValue(this.point);
            }
            writer.WriteSpan(StringPool.Slice(2584, 11)); // ,"x_shift":
            writer.WriteValue(this.x_shift);
            writer.WriteSpan(StringPool.Slice(2600, 11)); // ,"y_shift":
            writer.WriteValue(this.y_shift);
            writer.WriteSpan(StringPool.Slice(2616, 9)); // ,"scale":
            writer.WriteValue(this.scale);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Animation
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(2632, 20)); // {"@type":"animation"
            writer.WriteSpan(StringPool.Slice(2656, 12)); // ,"duration":
            writer.WriteValue(this.duration);
            writer.WriteSpan(StringPool.Slice(2400, 9)); // ,"width":
            writer.WriteValue(this.width);
            writer.WriteSpan(StringPool.Slice(2416, 10)); // ,"height":
            writer.WriteValue(this.height);
            writer.WriteSpan(StringPool.Slice(2672, 13)); // ,"file_name":
            writer.WriteValue(this.file_name);
            writer.WriteSpan(StringPool.Slice(2688, 13)); // ,"mime_type":
            writer.WriteValue(this.mime_type);
            if (this.thumbnail != null)
            {
                writer.WriteSpan(StringPool.Slice(2704, 13)); // ,"thumbnail":
                writer.WriteValue(this.thumbnail);
            }
            if (this.animation != null)
            {
                writer.WriteSpan(StringPool.Slice(2720, 13)); // ,"animation":
                writer.WriteValue(this.animation);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Audio
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(2736, 16)); // {"@type":"audio"
            writer.WriteSpan(StringPool.Slice(2656, 12)); // ,"duration":
            writer.WriteValue(this.duration);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(2768, 13)); // ,"performer":
            writer.WriteValue(this.performer);
            writer.WriteSpan(StringPool.Slice(2672, 13)); // ,"file_name":
            writer.WriteValue(this.file_name);
            writer.WriteSpan(StringPool.Slice(2688, 13)); // ,"mime_type":
            writer.WriteValue(this.mime_type);
            if (this.album_cover_thumbnail != null)
            {
                writer.WriteSpan(StringPool.Slice(2784, 25)); // ,"album_cover_thumbnail":
                writer.WriteValue(this.album_cover_thumbnail);
            }
            if (this.audio != null)
            {
                writer.WriteSpan(StringPool.Slice(2816, 9)); // ,"audio":
                writer.WriteValue(this.audio);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Document
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(2832, 19)); // {"@type":"document"
            writer.WriteSpan(StringPool.Slice(2672, 13)); // ,"file_name":
            writer.WriteValue(this.file_name);
            writer.WriteSpan(StringPool.Slice(2688, 13)); // ,"mime_type":
            writer.WriteValue(this.mime_type);
            if (this.thumbnail != null)
            {
                writer.WriteSpan(StringPool.Slice(2704, 13)); // ,"thumbnail":
                writer.WriteValue(this.thumbnail);
            }
            if (this.document != null)
            {
                writer.WriteSpan(StringPool.Slice(2856, 12)); // ,"document":
                writer.WriteValue(this.document);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Photo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(2872, 16)); // {"@type":"photo"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteInt64String(this.id);
            writer.WriteSpan(StringPool.Slice(2888, 16)); // ,"has_stickers":
            writer.WriteValue(this.has_stickers);
            if (this.sizes != null)
            {
                writer.WriteSpan(StringPool.Slice(2904, 9)); // ,"sizes":
                writer.WriteArray(this.sizes);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Sticker
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(2920, 18)); // {"@type":"sticker"
            writer.WriteSpan(StringPool.Slice(2944, 10)); // ,"set_id":
            writer.WriteInt64String(this.set_id);
            writer.WriteSpan(StringPool.Slice(2400, 9)); // ,"width":
            writer.WriteValue(this.width);
            writer.WriteSpan(StringPool.Slice(2416, 10)); // ,"height":
            writer.WriteValue(this.height);
            writer.WriteSpan(StringPool.Slice(2960, 9)); // ,"emoji":
            writer.WriteValue(this.emoji);
            writer.WriteSpan(StringPool.Slice(2976, 11)); // ,"is_mask":
            writer.WriteValue(this.is_mask);
            if (this.mask_position != null)
            {
                writer.WriteSpan(StringPool.Slice(2992, 17)); // ,"mask_position":
                writer.WriteValue(this.mask_position);
            }
            if (this.thumbnail != null)
            {
                writer.WriteSpan(StringPool.Slice(2704, 13)); // ,"thumbnail":
                writer.WriteValue(this.thumbnail);
            }
            if (this.sticker != null)
            {
                writer.WriteSpan(StringPool.Slice(3016, 11)); // ,"sticker":
                writer.WriteValue(this.sticker);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Video
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(3032, 16)); // {"@type":"video"
            writer.WriteSpan(StringPool.Slice(2656, 12)); // ,"duration":
            writer.WriteValue(this.duration);
            writer.WriteSpan(StringPool.Slice(2400, 9)); // ,"width":
            writer.WriteValue(this.width);
            writer.WriteSpan(StringPool.Slice(2416, 10)); // ,"height":
            writer.WriteValue(this.height);
            writer.WriteSpan(StringPool.Slice(2672, 13)); // ,"file_name":
            writer.WriteValue(this.file_name);
            writer.WriteSpan(StringPool.Slice(2688, 13)); // ,"mime_type":
            writer.WriteValue(this.mime_type);
            writer.WriteSpan(StringPool.Slice(2888, 16)); // ,"has_stickers":
            writer.WriteValue(this.has_stickers);
            writer.WriteSpan(StringPool.Slice(3048, 22)); // ,"supports_streaming":
            writer.WriteValue(this.supports_streaming);
            if (this.thumbnail != null)
            {
                writer.WriteSpan(StringPool.Slice(2704, 13)); // ,"thumbnail":
                writer.WriteValue(this.thumbnail);
            }
            if (this.video != null)
            {
                writer.WriteSpan(StringPool.Slice(3072, 9)); // ,"video":
                writer.WriteValue(this.video);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class VideoNote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(3088, 20)); // {"@type":"videoNote"
            writer.WriteSpan(StringPool.Slice(2656, 12)); // ,"duration":
            writer.WriteValue(this.duration);
            writer.WriteSpan(StringPool.Slice(496, 10)); // ,"length":
            writer.WriteValue(this.length);
            if (this.thumbnail != null)
            {
                writer.WriteSpan(StringPool.Slice(2704, 13)); // ,"thumbnail":
                writer.WriteValue(this.thumbnail);
            }
            if (this.video != null)
            {
                writer.WriteSpan(StringPool.Slice(3072, 9)); // ,"video":
                writer.WriteValue(this.video);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class VoiceNote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(3112, 20)); // {"@type":"voiceNote"
            writer.WriteSpan(StringPool.Slice(2656, 12)); // ,"duration":
            writer.WriteValue(this.duration);
            if (this.waveform != null)
            {
                writer.WriteSpan(StringPool.Slice(3136, 12)); // ,"waveform":
                writer.WriteBytesValue(this.waveform);
            }
            writer.WriteSpan(StringPool.Slice(2688, 13)); // ,"mime_type":
            writer.WriteValue(this.mime_type);
            if (this.voice != null)
            {
                writer.WriteSpan(StringPool.Slice(3152, 9)); // ,"voice":
                writer.WriteValue(this.voice);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Contact
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(3168, 18)); // {"@type":"contact"
            writer.WriteSpan(StringPool.Slice(696, 16)); // ,"phone_number":
            writer.WriteValue(this.phone_number);
            writer.WriteSpan(StringPool.Slice(3192, 14)); // ,"first_name":
            writer.WriteValue(this.first_name);
            writer.WriteSpan(StringPool.Slice(3208, 13)); // ,"last_name":
            writer.WriteValue(this.last_name);
            writer.WriteSpan(StringPool.Slice(3224, 9)); // ,"vcard":
            writer.WriteValue(this.vcard);
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Location
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(3256, 19)); // {"@type":"location"
            writer.WriteSpan(StringPool.Slice(3280, 12)); // ,"latitude":
            writer.WriteValue(this.latitude);
            writer.WriteSpan(StringPool.Slice(3296, 13)); // ,"longitude":
            writer.WriteValue(this.longitude);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Venue
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(3312, 16)); // {"@type":"venue"
            if (this.location != null)
            {
                writer.WriteSpan(StringPool.Slice(3328, 12)); // ,"location":
                writer.WriteValue(this.location);
            }
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(3344, 11)); // ,"address":
            writer.WriteValue(this.address);
            writer.WriteSpan(StringPool.Slice(3360, 12)); // ,"provider":
            writer.WriteValue(this.provider);
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
            writer.WriteValue(this.type);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Game
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(3376, 15)); // {"@type":"game"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteInt64String(this.id);
            writer.WriteSpan(StringPool.Slice(3392, 14)); // ,"short_name":
            writer.WriteValue(this.short_name);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            if (this.text != null)
            {
                writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
                writer.WriteValue(this.text);
            }
            writer.WriteSpan(StringPool.Slice(3408, 15)); // ,"description":
            writer.WriteValue(this.description);
            if (this.photo != null)
            {
                writer.WriteSpan(StringPool.Slice(2384, 9)); // ,"photo":
                writer.WriteValue(this.photo);
            }
            if (this.animation != null)
            {
                writer.WriteSpan(StringPool.Slice(2720, 13)); // ,"animation":
                writer.WriteValue(this.animation);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ProfilePhoto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(3424, 23)); // {"@type":"profilePhoto"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteInt64String(this.id);
            if (this.small != null)
            {
                writer.WriteSpan(StringPool.Slice(3448, 9)); // ,"small":
                writer.WriteValue(this.small);
            }
            if (this.big != null)
            {
                writer.WriteSpan(StringPool.Slice(3464, 7)); // ,"big":
                writer.WriteValue(this.big);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatPhoto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(3472, 20)); // {"@type":"chatPhoto"
            if (this.small != null)
            {
                writer.WriteSpan(StringPool.Slice(3448, 9)); // ,"small":
                writer.WriteValue(this.small);
            }
            if (this.big != null)
            {
                writer.WriteSpan(StringPool.Slice(3464, 7)); // ,"big":
                writer.WriteValue(this.big);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class LinkStateNone
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(3496, 24)); // {"@type":"linkStateNone"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class LinkStateKnowsPhoneNumber
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(3520, 36)); // {"@type":"linkStateKnowsPhoneNumber"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class LinkStateIsContact
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(3560, 29)); // {"@type":"linkStateIsContact"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserTypeRegular
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(3592, 26)); // {"@type":"userTypeRegular"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserTypeDeleted
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(3624, 26)); // {"@type":"userTypeDeleted"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserTypeBot
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(3656, 22)); // {"@type":"userTypeBot"
            writer.WriteSpan(StringPool.Slice(3680, 19)); // ,"can_join_groups":
            writer.WriteValue(this.can_join_groups);
            writer.WriteSpan(StringPool.Slice(3704, 31)); // ,"can_read_all_group_messages":
            writer.WriteValue(this.can_read_all_group_messages);
            writer.WriteSpan(StringPool.Slice(3736, 13)); // ,"is_inline":
            writer.WriteValue(this.is_inline);
            writer.WriteSpan(StringPool.Slice(3752, 28)); // ,"inline_query_placeholder":
            writer.WriteValue(this.inline_query_placeholder);
            writer.WriteSpan(StringPool.Slice(3784, 17)); // ,"need_location":
            writer.WriteValue(this.need_location);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserTypeUnknown
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(3808, 26)); // {"@type":"userTypeUnknown"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class BotCommand
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(3840, 21)); // {"@type":"botCommand"
            writer.WriteSpan(StringPool.Slice(3864, 11)); // ,"command":
            writer.WriteValue(this.command);
            writer.WriteSpan(StringPool.Slice(3408, 15)); // ,"description":
            writer.WriteValue(this.description);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class BotInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(3880, 18)); // {"@type":"botInfo"
            writer.WriteSpan(StringPool.Slice(3408, 15)); // ,"description":
            writer.WriteValue(this.description);
            if (this.commands != null)
            {
                writer.WriteSpan(StringPool.Slice(3904, 12)); // ,"commands":
                writer.WriteArray(this.commands);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class User
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(3920, 15)); // {"@type":"user"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(3192, 14)); // ,"first_name":
            writer.WriteValue(this.first_name);
            writer.WriteSpan(StringPool.Slice(3208, 13)); // ,"last_name":
            writer.WriteValue(this.last_name);
            writer.WriteSpan(StringPool.Slice(3936, 12)); // ,"username":
            writer.WriteValue(this.username);
            writer.WriteSpan(StringPool.Slice(696, 16)); // ,"phone_number":
            writer.WriteValue(this.phone_number);
            if (this.status != null)
            {
                writer.WriteSpan(StringPool.Slice(3952, 10)); // ,"status":
                writer.WriteValue(this.status);
            }
            if (this.profile_photo != null)
            {
                writer.WriteSpan(StringPool.Slice(3968, 17)); // ,"profile_photo":
                writer.WriteValue(this.profile_photo);
            }
            if (this.outgoing_link != null)
            {
                writer.WriteSpan(StringPool.Slice(3992, 17)); // ,"outgoing_link":
                writer.WriteValue(this.outgoing_link);
            }
            if (this.incoming_link != null)
            {
                writer.WriteSpan(StringPool.Slice(4016, 17)); // ,"incoming_link":
                writer.WriteValue(this.incoming_link);
            }
            writer.WriteSpan(StringPool.Slice(4040, 15)); // ,"is_verified":
            writer.WriteValue(this.is_verified);
            writer.WriteSpan(StringPool.Slice(4056, 22)); // ,"restriction_reason":
            writer.WriteValue(this.restriction_reason);
            writer.WriteSpan(StringPool.Slice(4080, 15)); // ,"have_access":
            writer.WriteValue(this.have_access);
            if (this.type != null)
            {
                writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
                writer.WriteValue(this.type);
            }
            writer.WriteSpan(StringPool.Slice(4096, 17)); // ,"language_code":
            writer.WriteValue(this.language_code);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserFullInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(4120, 23)); // {"@type":"userFullInfo"
            writer.WriteSpan(StringPool.Slice(4144, 14)); // ,"is_blocked":
            writer.WriteValue(this.is_blocked);
            writer.WriteSpan(StringPool.Slice(4160, 17)); // ,"can_be_called":
            writer.WriteValue(this.can_be_called);
            writer.WriteSpan(StringPool.Slice(4184, 21)); // ,"has_private_calls":
            writer.WriteValue(this.has_private_calls);
            writer.WriteSpan(StringPool.Slice(4208, 7)); // ,"bio":
            writer.WriteValue(this.bio);
            writer.WriteSpan(StringPool.Slice(4216, 14)); // ,"share_text":
            writer.WriteValue(this.share_text);
            writer.WriteSpan(StringPool.Slice(4232, 25)); // ,"group_in_common_count":
            writer.WriteValue(this.group_in_common_count);
            if (this.bot_info != null)
            {
                writer.WriteSpan(StringPool.Slice(4264, 12)); // ,"bot_info":
                writer.WriteValue(this.bot_info);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserProfilePhotos
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(4280, 28)); // {"@type":"userProfilePhotos"
            writer.WriteSpan(StringPool.Slice(4312, 15)); // ,"total_count":
            writer.WriteValue(this.total_count);
            if (this.photos != null)
            {
                writer.WriteSpan(StringPool.Slice(4328, 10)); // ,"photos":
                writer.WriteArray(this.photos);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Users
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(4344, 16)); // {"@type":"users"
            writer.WriteSpan(StringPool.Slice(4312, 15)); // ,"total_count":
            writer.WriteValue(this.total_count);
            if (this.user_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(4360, 12)); // ,"user_ids":
                writer.WriteArray(this.user_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatMemberStatusCreator
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(4376, 34)); // {"@type":"chatMemberStatusCreator"
            writer.WriteSpan(StringPool.Slice(4416, 13)); // ,"is_member":
            writer.WriteValue(this.is_member);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatMemberStatusAdministrator
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(4432, 40)); // {"@type":"chatMemberStatusAdministrator"
            writer.WriteSpan(StringPool.Slice(4472, 17)); // ,"can_be_edited":
            writer.WriteValue(this.can_be_edited);
            writer.WriteSpan(StringPool.Slice(4496, 19)); // ,"can_change_info":
            writer.WriteValue(this.can_change_info);
            writer.WriteSpan(StringPool.Slice(4520, 21)); // ,"can_post_messages":
            writer.WriteValue(this.can_post_messages);
            writer.WriteSpan(StringPool.Slice(4544, 21)); // ,"can_edit_messages":
            writer.WriteValue(this.can_edit_messages);
            writer.WriteSpan(StringPool.Slice(4568, 23)); // ,"can_delete_messages":
            writer.WriteValue(this.can_delete_messages);
            writer.WriteSpan(StringPool.Slice(4592, 20)); // ,"can_invite_users":
            writer.WriteValue(this.can_invite_users);
            writer.WriteSpan(StringPool.Slice(4616, 24)); // ,"can_restrict_members":
            writer.WriteValue(this.can_restrict_members);
            writer.WriteSpan(StringPool.Slice(4640, 20)); // ,"can_pin_messages":
            writer.WriteValue(this.can_pin_messages);
            writer.WriteSpan(StringPool.Slice(4664, 23)); // ,"can_promote_members":
            writer.WriteValue(this.can_promote_members);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatMemberStatusMember
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(4688, 33)); // {"@type":"chatMemberStatusMember"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatMemberStatusRestricted
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(4728, 37)); // {"@type":"chatMemberStatusRestricted"
            writer.WriteSpan(StringPool.Slice(4416, 13)); // ,"is_member":
            writer.WriteValue(this.is_member);
            writer.WriteSpan(StringPool.Slice(4768, 25)); // ,"restricted_until_date":
            writer.WriteValue(this.restricted_until_date);
            writer.WriteSpan(StringPool.Slice(4800, 21)); // ,"can_send_messages":
            writer.WriteValue(this.can_send_messages);
            writer.WriteSpan(StringPool.Slice(4824, 27)); // ,"can_send_media_messages":
            writer.WriteValue(this.can_send_media_messages);
            writer.WriteSpan(StringPool.Slice(4856, 27)); // ,"can_send_other_messages":
            writer.WriteValue(this.can_send_other_messages);
            writer.WriteSpan(StringPool.Slice(4888, 29)); // ,"can_add_web_page_previews":
            writer.WriteValue(this.can_add_web_page_previews);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatMemberStatusLeft
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(4920, 31)); // {"@type":"chatMemberStatusLeft"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatMemberStatusBanned
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(4952, 33)); // {"@type":"chatMemberStatusBanned"
            writer.WriteSpan(StringPool.Slice(4992, 21)); // ,"banned_until_date":
            writer.WriteValue(this.banned_until_date);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatMember
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(5016, 21)); // {"@type":"chatMember"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            writer.WriteSpan(StringPool.Slice(5040, 19)); // ,"inviter_user_id":
            writer.WriteValue(this.inviter_user_id);
            writer.WriteSpan(StringPool.Slice(5064, 20)); // ,"joined_chat_date":
            writer.WriteValue(this.joined_chat_date);
            if (this.status != null)
            {
                writer.WriteSpan(StringPool.Slice(3952, 10)); // ,"status":
                writer.WriteValue(this.status);
            }
            if (this.bot_info != null)
            {
                writer.WriteSpan(StringPool.Slice(4264, 12)); // ,"bot_info":
                writer.WriteValue(this.bot_info);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatMembers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(5088, 22)); // {"@type":"chatMembers"
            writer.WriteSpan(StringPool.Slice(4312, 15)); // ,"total_count":
            writer.WriteValue(this.total_count);
            if (this.members != null)
            {
                writer.WriteSpan(StringPool.Slice(5112, 11)); // ,"members":
                writer.WriteArray(this.members);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatMembersFilterAdministrators
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(5128, 42)); // {"@type":"chatMembersFilterAdministrators"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatMembersFilterMembers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(5176, 35)); // {"@type":"chatMembersFilterMembers"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatMembersFilterRestricted
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(5216, 38)); // {"@type":"chatMembersFilterRestricted"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatMembersFilterBanned
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(5256, 34)); // {"@type":"chatMembersFilterBanned"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatMembersFilterBots
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(5296, 32)); // {"@type":"chatMembersFilterBots"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SupergroupMembersFilterRecent
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(5328, 40)); // {"@type":"supergroupMembersFilterRecent"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SupergroupMembersFilterAdministrators
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(5368, 48)); // {"@type":"supergroupMembersFilterAdministrators"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SupergroupMembersFilterSearch
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(5416, 40)); // {"@type":"supergroupMembersFilterSearch"
            writer.WriteSpan(StringPool.Slice(5456, 9)); // ,"query":
            writer.WriteValue(this.query);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SupergroupMembersFilterRestricted
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(5472, 44)); // {"@type":"supergroupMembersFilterRestricted"
            writer.WriteSpan(StringPool.Slice(5456, 9)); // ,"query":
            writer.WriteValue(this.query);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SupergroupMembersFilterBanned
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(5520, 40)); // {"@type":"supergroupMembersFilterBanned"
            writer.WriteSpan(StringPool.Slice(5456, 9)); // ,"query":
            writer.WriteValue(this.query);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SupergroupMembersFilterBots
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(5560, 38)); // {"@type":"supergroupMembersFilterBots"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class BasicGroup
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(5600, 21)); // {"@type":"basicGroup"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(5624, 16)); // ,"member_count":
            writer.WriteValue(this.member_count);
            if (this.status != null)
            {
                writer.WriteSpan(StringPool.Slice(3952, 10)); // ,"status":
                writer.WriteValue(this.status);
            }
            writer.WriteSpan(StringPool.Slice(5640, 29)); // ,"everyone_is_administrator":
            writer.WriteValue(this.everyone_is_administrator);
            writer.WriteSpan(StringPool.Slice(5672, 13)); // ,"is_active":
            writer.WriteValue(this.is_active);
            writer.WriteSpan(StringPool.Slice(5688, 29)); // ,"upgraded_to_supergroup_id":
            writer.WriteValue(this.upgraded_to_supergroup_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class BasicGroupFullInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(5720, 29)); // {"@type":"basicGroupFullInfo"
            writer.WriteSpan(StringPool.Slice(5752, 19)); // ,"creator_user_id":
            writer.WriteValue(this.creator_user_id);
            if (this.members != null)
            {
                writer.WriteSpan(StringPool.Slice(5112, 11)); // ,"members":
                writer.WriteArray(this.members);
            }
            writer.WriteSpan(StringPool.Slice(5776, 15)); // ,"invite_link":
            writer.WriteValue(this.invite_link);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Supergroup
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(5792, 21)); // {"@type":"supergroup"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(3936, 12)); // ,"username":
            writer.WriteValue(this.username);
            writer.WriteSpan(StringPool.Slice(5816, 8)); // ,"date":
            writer.WriteValue(this.date);
            if (this.status != null)
            {
                writer.WriteSpan(StringPool.Slice(3952, 10)); // ,"status":
                writer.WriteValue(this.status);
            }
            writer.WriteSpan(StringPool.Slice(5624, 16)); // ,"member_count":
            writer.WriteValue(this.member_count);
            writer.WriteSpan(StringPool.Slice(5824, 21)); // ,"anyone_can_invite":
            writer.WriteValue(this.anyone_can_invite);
            writer.WriteSpan(StringPool.Slice(5848, 17)); // ,"sign_messages":
            writer.WriteValue(this.sign_messages);
            writer.WriteSpan(StringPool.Slice(5872, 14)); // ,"is_channel":
            writer.WriteValue(this.is_channel);
            writer.WriteSpan(StringPool.Slice(4040, 15)); // ,"is_verified":
            writer.WriteValue(this.is_verified);
            writer.WriteSpan(StringPool.Slice(4056, 22)); // ,"restriction_reason":
            writer.WriteValue(this.restriction_reason);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SupergroupFullInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(5888, 29)); // {"@type":"supergroupFullInfo"
            writer.WriteSpan(StringPool.Slice(3408, 15)); // ,"description":
            writer.WriteValue(this.description);
            writer.WriteSpan(StringPool.Slice(5624, 16)); // ,"member_count":
            writer.WriteValue(this.member_count);
            writer.WriteSpan(StringPool.Slice(5920, 23)); // ,"administrator_count":
            writer.WriteValue(this.administrator_count);
            writer.WriteSpan(StringPool.Slice(5944, 20)); // ,"restricted_count":
            writer.WriteValue(this.restricted_count);
            writer.WriteSpan(StringPool.Slice(5968, 16)); // ,"banned_count":
            writer.WriteValue(this.banned_count);
            writer.WriteSpan(StringPool.Slice(5984, 19)); // ,"can_get_members":
            writer.WriteValue(this.can_get_members);
            writer.WriteSpan(StringPool.Slice(6008, 20)); // ,"can_set_username":
            writer.WriteValue(this.can_set_username);
            writer.WriteSpan(StringPool.Slice(6032, 23)); // ,"can_set_sticker_set":
            writer.WriteValue(this.can_set_sticker_set);
            writer.WriteSpan(StringPool.Slice(6056, 28)); // ,"is_all_history_available":
            writer.WriteValue(this.is_all_history_available);
            writer.WriteSpan(StringPool.Slice(6088, 18)); // ,"sticker_set_id":
            writer.WriteInt64String(this.sticker_set_id);
            writer.WriteSpan(StringPool.Slice(5776, 15)); // ,"invite_link":
            writer.WriteValue(this.invite_link);
            writer.WriteSpan(StringPool.Slice(6112, 21)); // ,"pinned_message_id":
            writer.WriteValue(this.pinned_message_id);
            writer.WriteSpan(StringPool.Slice(6136, 32)); // ,"upgraded_from_basic_group_id":
            writer.WriteValue(this.upgraded_from_basic_group_id);
            writer.WriteSpan(StringPool.Slice(6168, 32)); // ,"upgraded_from_max_message_id":
            writer.WriteValue(this.upgraded_from_max_message_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SecretChatStatePending
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(6200, 33)); // {"@type":"secretChatStatePending"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SecretChatStateReady
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(6240, 31)); // {"@type":"secretChatStateReady"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SecretChatStateClosed
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(6272, 32)); // {"@type":"secretChatStateClosed"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SecretChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(6304, 21)); // {"@type":"secretChat"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            if (this.state != null)
            {
                writer.WriteSpan(StringPool.Slice(6328, 9)); // ,"state":
                writer.WriteValue(this.state);
            }
            writer.WriteSpan(StringPool.Slice(6344, 15)); // ,"is_outbound":
            writer.WriteValue(this.is_outbound);
            writer.WriteSpan(StringPool.Slice(6360, 7)); // ,"ttl":
            writer.WriteValue(this.ttl);
            if (this.key_hash != null)
            {
                writer.WriteSpan(StringPool.Slice(6368, 12)); // ,"key_hash":
                writer.WriteBytesValue(this.key_hash);
            }
            writer.WriteSpan(StringPool.Slice(6384, 9)); // ,"layer":
            writer.WriteValue(this.layer);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageForwardedFromUser
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(6400, 35)); // {"@type":"messageForwardedFromUser"
            writer.WriteSpan(StringPool.Slice(6440, 18)); // ,"sender_user_id":
            writer.WriteValue(this.sender_user_id);
            writer.WriteSpan(StringPool.Slice(5816, 8)); // ,"date":
            writer.WriteValue(this.date);
            writer.WriteSpan(StringPool.Slice(6464, 26)); // ,"forwarded_from_chat_id":
            writer.WriteValue(this.forwarded_from_chat_id);
            writer.WriteSpan(StringPool.Slice(6496, 29)); // ,"forwarded_from_message_id":
            writer.WriteValue(this.forwarded_from_message_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageForwardedPost
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(6528, 31)); // {"@type":"messageForwardedPost"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6576, 20)); // ,"author_signature":
            writer.WriteValue(this.author_signature);
            writer.WriteSpan(StringPool.Slice(5816, 8)); // ,"date":
            writer.WriteValue(this.date);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            writer.WriteSpan(StringPool.Slice(6464, 26)); // ,"forwarded_from_chat_id":
            writer.WriteValue(this.forwarded_from_chat_id);
            writer.WriteSpan(StringPool.Slice(6496, 29)); // ,"forwarded_from_message_id":
            writer.WriteValue(this.forwarded_from_message_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageSendingStatePending
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(6616, 37)); // {"@type":"messageSendingStatePending"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageSendingStateFailed
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(6656, 36)); // {"@type":"messageSendingStateFailed"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Message
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(6696, 18)); // {"@type":"message"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(6440, 18)); // ,"sender_user_id":
            writer.WriteValue(this.sender_user_id);
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            if (this.sending_state != null)
            {
                writer.WriteSpan(StringPool.Slice(6720, 17)); // ,"sending_state":
                writer.WriteValue(this.sending_state);
            }
            writer.WriteSpan(StringPool.Slice(6744, 15)); // ,"is_outgoing":
            writer.WriteValue(this.is_outgoing);
            writer.WriteSpan(StringPool.Slice(4472, 17)); // ,"can_be_edited":
            writer.WriteValue(this.can_be_edited);
            writer.WriteSpan(StringPool.Slice(6760, 20)); // ,"can_be_forwarded":
            writer.WriteValue(this.can_be_forwarded);
            writer.WriteSpan(StringPool.Slice(6784, 32)); // ,"can_be_deleted_only_for_self":
            writer.WriteValue(this.can_be_deleted_only_for_self);
            writer.WriteSpan(StringPool.Slice(6816, 32)); // ,"can_be_deleted_for_all_users":
            writer.WriteValue(this.can_be_deleted_for_all_users);
            writer.WriteSpan(StringPool.Slice(6848, 19)); // ,"is_channel_post":
            writer.WriteValue(this.is_channel_post);
            writer.WriteSpan(StringPool.Slice(6872, 27)); // ,"contains_unread_mention":
            writer.WriteValue(this.contains_unread_mention);
            writer.WriteSpan(StringPool.Slice(5816, 8)); // ,"date":
            writer.WriteValue(this.date);
            writer.WriteSpan(StringPool.Slice(6904, 13)); // ,"edit_date":
            writer.WriteValue(this.edit_date);
            if (this.forward_info != null)
            {
                writer.WriteSpan(StringPool.Slice(6920, 16)); // ,"forward_info":
                writer.WriteValue(this.forward_info);
            }
            writer.WriteSpan(StringPool.Slice(6936, 23)); // ,"reply_to_message_id":
            writer.WriteValue(this.reply_to_message_id);
            writer.WriteSpan(StringPool.Slice(6360, 7)); // ,"ttl":
            writer.WriteValue(this.ttl);
            writer.WriteSpan(StringPool.Slice(6960, 18)); // ,"ttl_expires_in":
            writer.WriteValue(this.ttl_expires_in);
            writer.WriteSpan(StringPool.Slice(6984, 19)); // ,"via_bot_user_id":
            writer.WriteValue(this.via_bot_user_id);
            writer.WriteSpan(StringPool.Slice(6576, 20)); // ,"author_signature":
            writer.WriteValue(this.author_signature);
            writer.WriteSpan(StringPool.Slice(7008, 9)); // ,"views":
            writer.WriteValue(this.views);
            writer.WriteSpan(StringPool.Slice(7024, 18)); // ,"media_album_id":
            writer.WriteInt64String(this.media_album_id);
            if (this.content != null)
            {
                writer.WriteSpan(StringPool.Slice(7048, 11)); // ,"content":
                writer.WriteValue(this.content);
            }
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Messages
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(7080, 19)); // {"@type":"messages"
            writer.WriteSpan(StringPool.Slice(4312, 15)); // ,"total_count":
            writer.WriteValue(this.total_count);
            if (this.messages != null)
            {
                writer.WriteSpan(StringPool.Slice(7104, 12)); // ,"messages":
                writer.WriteArray(this.messages);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class FoundMessages
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(7120, 24)); // {"@type":"foundMessages"
            if (this.messages != null)
            {
                writer.WriteSpan(StringPool.Slice(7104, 12)); // ,"messages":
                writer.WriteArray(this.messages);
            }
            writer.WriteSpan(StringPool.Slice(7144, 23)); // ,"next_from_search_id":
            writer.WriteInt64String(this.next_from_search_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class NotificationSettingsScopePrivateChats
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(7168, 48)); // {"@type":"notificationSettingsScopePrivateChats"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class NotificationSettingsScopeGroupChats
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(7216, 46)); // {"@type":"notificationSettingsScopeGroupChats"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatNotificationSettings
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(7264, 35)); // {"@type":"chatNotificationSettings"
            writer.WriteSpan(StringPool.Slice(7304, 24)); // ,"use_default_mute_for":
            writer.WriteValue(this.use_default_mute_for);
            writer.WriteSpan(StringPool.Slice(7328, 12)); // ,"mute_for":
            writer.WriteValue(this.mute_for);
            writer.WriteSpan(StringPool.Slice(7344, 21)); // ,"use_default_sound":
            writer.WriteValue(this.use_default_sound);
            writer.WriteSpan(StringPool.Slice(7368, 9)); // ,"sound":
            writer.WriteValue(this.sound);
            writer.WriteSpan(StringPool.Slice(7384, 28)); // ,"use_default_show_preview":
            writer.WriteValue(this.use_default_show_preview);
            writer.WriteSpan(StringPool.Slice(7416, 16)); // ,"show_preview":
            writer.WriteValue(this.show_preview);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ScopeNotificationSettings
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(7432, 36)); // {"@type":"scopeNotificationSettings"
            writer.WriteSpan(StringPool.Slice(7328, 12)); // ,"mute_for":
            writer.WriteValue(this.mute_for);
            writer.WriteSpan(StringPool.Slice(7368, 9)); // ,"sound":
            writer.WriteValue(this.sound);
            writer.WriteSpan(StringPool.Slice(7416, 16)); // ,"show_preview":
            writer.WriteValue(this.show_preview);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DraftMessage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(7472, 23)); // {"@type":"draftMessage"
            writer.WriteSpan(StringPool.Slice(6936, 23)); // ,"reply_to_message_id":
            writer.WriteValue(this.reply_to_message_id);
            if (this.input_message_text != null)
            {
                writer.WriteSpan(StringPool.Slice(7496, 22)); // ,"input_message_text":
                writer.WriteValue(this.input_message_text);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatTypePrivate
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(7520, 26)); // {"@type":"chatTypePrivate"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatTypeBasicGroup
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(7552, 29)); // {"@type":"chatTypeBasicGroup"
            writer.WriteSpan(StringPool.Slice(7584, 18)); // ,"basic_group_id":
            writer.WriteValue(this.basic_group_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatTypeSupergroup
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(7608, 29)); // {"@type":"chatTypeSupergroup"
            writer.WriteSpan(StringPool.Slice(7640, 17)); // ,"supergroup_id":
            writer.WriteValue(this.supergroup_id);
            writer.WriteSpan(StringPool.Slice(5872, 14)); // ,"is_channel":
            writer.WriteValue(this.is_channel);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatTypeSecret
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(7664, 25)); // {"@type":"chatTypeSecret"
            writer.WriteSpan(StringPool.Slice(7696, 18)); // ,"secret_chat_id":
            writer.WriteValue(this.secret_chat_id);
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Chat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(7720, 15)); // {"@type":"chat"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            if (this.type != null)
            {
                writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
                writer.WriteValue(this.type);
            }
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            if (this.photo != null)
            {
                writer.WriteSpan(StringPool.Slice(2384, 9)); // ,"photo":
                writer.WriteValue(this.photo);
            }
            if (this.last_message != null)
            {
                writer.WriteSpan(StringPool.Slice(7736, 16)); // ,"last_message":
                writer.WriteValue(this.last_message);
            }
            writer.WriteSpan(StringPool.Slice(7752, 9)); // ,"order":
            writer.WriteInt64String(this.order);
            writer.WriteSpan(StringPool.Slice(7768, 13)); // ,"is_pinned":
            writer.WriteValue(this.is_pinned);
            writer.WriteSpan(StringPool.Slice(7784, 23)); // ,"is_marked_as_unread":
            writer.WriteValue(this.is_marked_as_unread);
            writer.WriteSpan(StringPool.Slice(7808, 16)); // ,"is_sponsored":
            writer.WriteValue(this.is_sponsored);
            writer.WriteSpan(StringPool.Slice(7824, 19)); // ,"can_be_reported":
            writer.WriteValue(this.can_be_reported);
            writer.WriteSpan(StringPool.Slice(7848, 32)); // ,"default_disable_notification":
            writer.WriteValue(this.default_disable_notification);
            writer.WriteSpan(StringPool.Slice(7880, 16)); // ,"unread_count":
            writer.WriteValue(this.unread_count);
            writer.WriteSpan(StringPool.Slice(7896, 30)); // ,"last_read_inbox_message_id":
            writer.WriteValue(this.last_read_inbox_message_id);
            writer.WriteSpan(StringPool.Slice(7928, 31)); // ,"last_read_outbox_message_id":
            writer.WriteValue(this.last_read_outbox_message_id);
            writer.WriteSpan(StringPool.Slice(7960, 24)); // ,"unread_mention_count":
            writer.WriteValue(this.unread_mention_count);
            if (this.notification_settings != null)
            {
                writer.WriteSpan(StringPool.Slice(7984, 25)); // ,"notification_settings":
                writer.WriteValue(this.notification_settings);
            }
            writer.WriteSpan(StringPool.Slice(8016, 27)); // ,"reply_markup_message_id":
            writer.WriteValue(this.reply_markup_message_id);
            if (this.draft_message != null)
            {
                writer.WriteSpan(StringPool.Slice(8048, 17)); // ,"draft_message":
                writer.WriteValue(this.draft_message);
            }
            writer.WriteSpan(StringPool.Slice(8072, 15)); // ,"client_data":
            writer.WriteValue(this.client_data);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Chats
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8088, 16)); // {"@type":"chats"
            if (this.chat_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(8104, 12)); // ,"chat_ids":
                writer.WriteArray(this.chat_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatInviteLink
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8120, 25)); // {"@type":"chatInviteLink"
            writer.WriteSpan(StringPool.Slice(5776, 15)); // ,"invite_link":
            writer.WriteValue(this.invite_link);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatInviteLinkInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8152, 29)); // {"@type":"chatInviteLinkInfo"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            if (this.type != null)
            {
                writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
                writer.WriteValue(this.type);
            }
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            if (this.photo != null)
            {
                writer.WriteSpan(StringPool.Slice(2384, 9)); // ,"photo":
                writer.WriteValue(this.photo);
            }
            writer.WriteSpan(StringPool.Slice(5624, 16)); // ,"member_count":
            writer.WriteValue(this.member_count);
            if (this.member_user_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(8184, 19)); // ,"member_user_ids":
                writer.WriteArray(this.member_user_ids);
            }
            writer.WriteSpan(StringPool.Slice(8208, 13)); // ,"is_public":
            writer.WriteValue(this.is_public);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class KeyboardButtonTypeText
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8224, 33)); // {"@type":"keyboardButtonTypeText"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class KeyboardButtonTypeRequestPhoneNumber
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8264, 47)); // {"@type":"keyboardButtonTypeRequestPhoneNumber"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class KeyboardButtonTypeRequestLocation
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8312, 44)); // {"@type":"keyboardButtonTypeRequestLocation"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class KeyboardButton
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8360, 25)); // {"@type":"keyboardButton"
            writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
            writer.WriteValue(this.text);
            if (this.type != null)
            {
                writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
                writer.WriteValue(this.type);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InlineKeyboardButtonTypeUrl
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8392, 38)); // {"@type":"inlineKeyboardButtonTypeUrl"
            writer.WriteSpan(StringPool.Slice(8432, 7)); // ,"url":
            writer.WriteValue(this.url);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InlineKeyboardButtonTypeCallback
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8440, 43)); // {"@type":"inlineKeyboardButtonTypeCallback"
            if (this.data != null)
            {
                writer.WriteSpan(StringPool.Slice(8488, 8)); // ,"data":
                writer.WriteBytesValue(this.data);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InlineKeyboardButtonTypeCallbackGame
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8496, 47)); // {"@type":"inlineKeyboardButtonTypeCallbackGame"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InlineKeyboardButtonTypeSwitchInline
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8544, 47)); // {"@type":"inlineKeyboardButtonTypeSwitchInline"
            writer.WriteSpan(StringPool.Slice(5456, 9)); // ,"query":
            writer.WriteValue(this.query);
            writer.WriteSpan(StringPool.Slice(8592, 19)); // ,"in_current_chat":
            writer.WriteValue(this.in_current_chat);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InlineKeyboardButtonTypeBuy
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8616, 38)); // {"@type":"inlineKeyboardButtonTypeBuy"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InlineKeyboardButton
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8656, 31)); // {"@type":"inlineKeyboardButton"
            writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
            writer.WriteValue(this.text);
            if (this.type != null)
            {
                writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
                writer.WriteValue(this.type);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ReplyMarkupRemoveKeyboard
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8688, 36)); // {"@type":"replyMarkupRemoveKeyboard"
            writer.WriteSpan(StringPool.Slice(8728, 15)); // ,"is_personal":
            writer.WriteValue(this.is_personal);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ReplyMarkupForceReply
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8744, 32)); // {"@type":"replyMarkupForceReply"
            writer.WriteSpan(StringPool.Slice(8728, 15)); // ,"is_personal":
            writer.WriteValue(this.is_personal);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ReplyMarkupShowKeyboard
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8776, 34)); // {"@type":"replyMarkupShowKeyboard"
            if (this.rows != null)
            {
                writer.WriteSpan(StringPool.Slice(8816, 8)); // ,"rows":
                writer.WriteArray(this.rows);
            }
            writer.WriteSpan(StringPool.Slice(8824, 19)); // ,"resize_keyboard":
            writer.WriteValue(this.resize_keyboard);
            writer.WriteSpan(StringPool.Slice(8848, 12)); // ,"one_time":
            writer.WriteValue(this.one_time);
            writer.WriteSpan(StringPool.Slice(8728, 15)); // ,"is_personal":
            writer.WriteValue(this.is_personal);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ReplyMarkupInlineKeyboard
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8864, 36)); // {"@type":"replyMarkupInlineKeyboard"
            if (this.rows != null)
            {
                writer.WriteSpan(StringPool.Slice(8816, 8)); // ,"rows":
                writer.WriteArray(this.rows);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RichTextPlain
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8904, 24)); // {"@type":"richTextPlain"
            writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
            writer.WriteValue(this.text);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RichTextBold
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8928, 23)); // {"@type":"richTextBold"
            if (this.text != null)
            {
                writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
                writer.WriteValue(this.text);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RichTextItalic
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8952, 25)); // {"@type":"richTextItalic"
            if (this.text != null)
            {
                writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
                writer.WriteValue(this.text);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RichTextUnderline
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(8984, 28)); // {"@type":"richTextUnderline"
            if (this.text != null)
            {
                writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
                writer.WriteValue(this.text);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RichTextStrikethrough
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9016, 32)); // {"@type":"richTextStrikethrough"
            if (this.text != null)
            {
                writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
                writer.WriteValue(this.text);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RichTextFixed
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9048, 24)); // {"@type":"richTextFixed"
            if (this.text != null)
            {
                writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
                writer.WriteValue(this.text);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RichTextUrl
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9072, 22)); // {"@type":"richTextUrl"
            if (this.text != null)
            {
                writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
                writer.WriteValue(this.text);
            }
            writer.WriteSpan(StringPool.Slice(8432, 7)); // ,"url":
            writer.WriteValue(this.url);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RichTextEmailAddress
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9096, 31)); // {"@type":"richTextEmailAddress"
            if (this.text != null)
            {
                writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
                writer.WriteValue(this.text);
            }
            writer.WriteSpan(StringPool.Slice(9128, 17)); // ,"email_address":
            writer.WriteValue(this.email_address);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RichTexts
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9152, 20)); // {"@type":"richTexts"
            if (this.texts != null)
            {
                writer.WriteSpan(StringPool.Slice(9176, 9)); // ,"texts":
                writer.WriteArray(this.texts);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockTitle
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9192, 25)); // {"@type":"pageBlockTitle"
            if (this.title != null)
            {
                writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
                writer.WriteValue(this.title);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockSubtitle
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9224, 28)); // {"@type":"pageBlockSubtitle"
            if (this.subtitle != null)
            {
                writer.WriteSpan(StringPool.Slice(9256, 12)); // ,"subtitle":
                writer.WriteValue(this.subtitle);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockAuthorDate
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9272, 30)); // {"@type":"pageBlockAuthorDate"
            if (this.author != null)
            {
                writer.WriteSpan(StringPool.Slice(9304, 10)); // ,"author":
                writer.WriteValue(this.author);
            }
            writer.WriteSpan(StringPool.Slice(9320, 16)); // ,"publish_date":
            writer.WriteValue(this.publish_date);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockHeader
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9336, 26)); // {"@type":"pageBlockHeader"
            if (this.header != null)
            {
                writer.WriteSpan(StringPool.Slice(9368, 10)); // ,"header":
                writer.WriteValue(this.header);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockSubheader
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9384, 29)); // {"@type":"pageBlockSubheader"
            if (this.subheader != null)
            {
                writer.WriteSpan(StringPool.Slice(9416, 13)); // ,"subheader":
                writer.WriteValue(this.subheader);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockParagraph
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9432, 29)); // {"@type":"pageBlockParagraph"
            if (this.text != null)
            {
                writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
                writer.WriteValue(this.text);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockPreformatted
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9464, 32)); // {"@type":"pageBlockPreformatted"
            if (this.text != null)
            {
                writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
                writer.WriteValue(this.text);
            }
            writer.WriteSpan(StringPool.Slice(9496, 12)); // ,"language":
            writer.WriteValue(this.language);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockFooter
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9512, 26)); // {"@type":"pageBlockFooter"
            if (this.footer != null)
            {
                writer.WriteSpan(StringPool.Slice(9544, 10)); // ,"footer":
                writer.WriteValue(this.footer);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockDivider
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9560, 27)); // {"@type":"pageBlockDivider"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockAnchor
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9592, 26)); // {"@type":"pageBlockAnchor"
            writer.WriteSpan(StringPool.Slice(9624, 8)); // ,"name":
            writer.WriteValue(this.name);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockList
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9632, 24)); // {"@type":"pageBlockList"
            if (this.items != null)
            {
                writer.WriteSpan(StringPool.Slice(9656, 9)); // ,"items":
                writer.WriteArray(this.items);
            }
            writer.WriteSpan(StringPool.Slice(9672, 14)); // ,"is_ordered":
            writer.WriteValue(this.is_ordered);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockBlockQuote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9688, 30)); // {"@type":"pageBlockBlockQuote"
            if (this.text != null)
            {
                writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
                writer.WriteValue(this.text);
            }
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockPullQuote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9736, 29)); // {"@type":"pageBlockPullQuote"
            if (this.text != null)
            {
                writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
                writer.WriteValue(this.text);
            }
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockAnimation
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9768, 29)); // {"@type":"pageBlockAnimation"
            if (this.animation != null)
            {
                writer.WriteSpan(StringPool.Slice(2720, 13)); // ,"animation":
                writer.WriteValue(this.animation);
            }
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            writer.WriteSpan(StringPool.Slice(9800, 17)); // ,"need_autoplay":
            writer.WriteValue(this.need_autoplay);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockAudio
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9824, 25)); // {"@type":"pageBlockAudio"
            if (this.audio != null)
            {
                writer.WriteSpan(StringPool.Slice(2816, 9)); // ,"audio":
                writer.WriteValue(this.audio);
            }
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockPhoto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9856, 25)); // {"@type":"pageBlockPhoto"
            if (this.photo != null)
            {
                writer.WriteSpan(StringPool.Slice(2384, 9)); // ,"photo":
                writer.WriteValue(this.photo);
            }
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockVideo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9888, 25)); // {"@type":"pageBlockVideo"
            if (this.video != null)
            {
                writer.WriteSpan(StringPool.Slice(3072, 9)); // ,"video":
                writer.WriteValue(this.video);
            }
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            writer.WriteSpan(StringPool.Slice(9800, 17)); // ,"need_autoplay":
            writer.WriteValue(this.need_autoplay);
            writer.WriteSpan(StringPool.Slice(9920, 13)); // ,"is_looped":
            writer.WriteValue(this.is_looped);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockCover
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9936, 25)); // {"@type":"pageBlockCover"
            if (this.cover != null)
            {
                writer.WriteSpan(StringPool.Slice(9968, 9)); // ,"cover":
                writer.WriteValue(this.cover);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockEmbedded
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(9984, 28)); // {"@type":"pageBlockEmbedded"
            writer.WriteSpan(StringPool.Slice(8432, 7)); // ,"url":
            writer.WriteValue(this.url);
            writer.WriteSpan(StringPool.Slice(10016, 8)); // ,"html":
            writer.WriteValue(this.html);
            if (this.poster_photo != null)
            {
                writer.WriteSpan(StringPool.Slice(10024, 16)); // ,"poster_photo":
                writer.WriteValue(this.poster_photo);
            }
            writer.WriteSpan(StringPool.Slice(2400, 9)); // ,"width":
            writer.WriteValue(this.width);
            writer.WriteSpan(StringPool.Slice(2416, 10)); // ,"height":
            writer.WriteValue(this.height);
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            writer.WriteSpan(StringPool.Slice(10040, 17)); // ,"is_full_width":
            writer.WriteValue(this.is_full_width);
            writer.WriteSpan(StringPool.Slice(10064, 19)); // ,"allow_scrolling":
            writer.WriteValue(this.allow_scrolling);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockEmbeddedPost
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(10088, 32)); // {"@type":"pageBlockEmbeddedPost"
            writer.WriteSpan(StringPool.Slice(8432, 7)); // ,"url":
            writer.WriteValue(this.url);
            writer.WriteSpan(StringPool.Slice(9304, 10)); // ,"author":
            writer.WriteValue(this.author);
            if (this.author_photo != null)
            {
                writer.WriteSpan(StringPool.Slice(10120, 16)); // ,"author_photo":
                writer.WriteValue(this.author_photo);
            }
            writer.WriteSpan(StringPool.Slice(5816, 8)); // ,"date":
            writer.WriteValue(this.date);
            if (this.page_blocks != null)
            {
                writer.WriteSpan(StringPool.Slice(10136, 15)); // ,"page_blocks":
                writer.WriteArray(this.page_blocks);
            }
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockCollage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(10152, 27)); // {"@type":"pageBlockCollage"
            if (this.page_blocks != null)
            {
                writer.WriteSpan(StringPool.Slice(10136, 15)); // ,"page_blocks":
                writer.WriteArray(this.page_blocks);
            }
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockSlideshow
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(10184, 29)); // {"@type":"pageBlockSlideshow"
            if (this.page_blocks != null)
            {
                writer.WriteSpan(StringPool.Slice(10136, 15)); // ,"page_blocks":
                writer.WriteArray(this.page_blocks);
            }
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PageBlockChatLink
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(10216, 28)); // {"@type":"pageBlockChatLink"
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            if (this.photo != null)
            {
                writer.WriteSpan(StringPool.Slice(2384, 9)); // ,"photo":
                writer.WriteValue(this.photo);
            }
            writer.WriteSpan(StringPool.Slice(3936, 12)); // ,"username":
            writer.WriteValue(this.username);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class WebPageInstantView
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(10248, 29)); // {"@type":"webPageInstantView"
            if (this.page_blocks != null)
            {
                writer.WriteSpan(StringPool.Slice(10136, 15)); // ,"page_blocks":
                writer.WriteArray(this.page_blocks);
            }
            writer.WriteSpan(StringPool.Slice(10280, 11)); // ,"is_full":
            writer.WriteValue(this.is_full);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class WebPage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(10296, 18)); // {"@type":"webPage"
            writer.WriteSpan(StringPool.Slice(8432, 7)); // ,"url":
            writer.WriteValue(this.url);
            writer.WriteSpan(StringPool.Slice(10320, 15)); // ,"display_url":
            writer.WriteValue(this.display_url);
            writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
            writer.WriteValue(this.type);
            writer.WriteSpan(StringPool.Slice(10336, 13)); // ,"site_name":
            writer.WriteValue(this.site_name);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(3408, 15)); // ,"description":
            writer.WriteValue(this.description);
            if (this.photo != null)
            {
                writer.WriteSpan(StringPool.Slice(2384, 9)); // ,"photo":
                writer.WriteValue(this.photo);
            }
            writer.WriteSpan(StringPool.Slice(10352, 13)); // ,"embed_url":
            writer.WriteValue(this.embed_url);
            writer.WriteSpan(StringPool.Slice(10368, 14)); // ,"embed_type":
            writer.WriteValue(this.embed_type);
            writer.WriteSpan(StringPool.Slice(10384, 15)); // ,"embed_width":
            writer.WriteValue(this.embed_width);
            writer.WriteSpan(StringPool.Slice(10400, 16)); // ,"embed_height":
            writer.WriteValue(this.embed_height);
            writer.WriteSpan(StringPool.Slice(2656, 12)); // ,"duration":
            writer.WriteValue(this.duration);
            writer.WriteSpan(StringPool.Slice(9304, 10)); // ,"author":
            writer.WriteValue(this.author);
            if (this.animation != null)
            {
                writer.WriteSpan(StringPool.Slice(2720, 13)); // ,"animation":
                writer.WriteValue(this.animation);
            }
            if (this.audio != null)
            {
                writer.WriteSpan(StringPool.Slice(2816, 9)); // ,"audio":
                writer.WriteValue(this.audio);
            }
            if (this.document != null)
            {
                writer.WriteSpan(StringPool.Slice(2856, 12)); // ,"document":
                writer.WriteValue(this.document);
            }
            if (this.sticker != null)
            {
                writer.WriteSpan(StringPool.Slice(3016, 11)); // ,"sticker":
                writer.WriteValue(this.sticker);
            }
            if (this.video != null)
            {
                writer.WriteSpan(StringPool.Slice(3072, 9)); // ,"video":
                writer.WriteValue(this.video);
            }
            if (this.video_note != null)
            {
                writer.WriteSpan(StringPool.Slice(10416, 14)); // ,"video_note":
                writer.WriteValue(this.video_note);
            }
            if (this.voice_note != null)
            {
                writer.WriteSpan(StringPool.Slice(10432, 14)); // ,"voice_note":
                writer.WriteValue(this.voice_note);
            }
            writer.WriteSpan(StringPool.Slice(10448, 20)); // ,"has_instant_view":
            writer.WriteValue(this.has_instant_view);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Address
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(10472, 18)); // {"@type":"address"
            writer.WriteSpan(StringPool.Slice(10496, 16)); // ,"country_code":
            writer.WriteValue(this.country_code);
            writer.WriteSpan(StringPool.Slice(6328, 9)); // ,"state":
            writer.WriteValue(this.state);
            writer.WriteSpan(StringPool.Slice(10512, 8)); // ,"city":
            writer.WriteValue(this.city);
            writer.WriteSpan(StringPool.Slice(10520, 16)); // ,"street_line1":
            writer.WriteValue(this.street_line1);
            writer.WriteSpan(StringPool.Slice(10536, 16)); // ,"street_line2":
            writer.WriteValue(this.street_line2);
            writer.WriteSpan(StringPool.Slice(10552, 15)); // ,"postal_code":
            writer.WriteValue(this.postal_code);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class LabeledPricePart
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(10568, 27)); // {"@type":"labeledPricePart"
            writer.WriteSpan(StringPool.Slice(10600, 9)); // ,"label":
            writer.WriteValue(this.label);
            writer.WriteSpan(StringPool.Slice(10616, 10)); // ,"amount":
            writer.WriteValue(this.amount);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Invoice
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(10632, 18)); // {"@type":"invoice"
            writer.WriteSpan(StringPool.Slice(10656, 12)); // ,"currency":
            writer.WriteValue(this.currency);
            if (this.price_parts != null)
            {
                writer.WriteSpan(StringPool.Slice(10672, 15)); // ,"price_parts":
                writer.WriteArray(this.price_parts);
            }
            writer.WriteSpan(StringPool.Slice(10688, 11)); // ,"is_test":
            writer.WriteValue(this.is_test);
            writer.WriteSpan(StringPool.Slice(10704, 13)); // ,"need_name":
            writer.WriteValue(this.need_name);
            writer.WriteSpan(StringPool.Slice(10720, 21)); // ,"need_phone_number":
            writer.WriteValue(this.need_phone_number);
            writer.WriteSpan(StringPool.Slice(10744, 22)); // ,"need_email_address":
            writer.WriteValue(this.need_email_address);
            writer.WriteSpan(StringPool.Slice(10768, 25)); // ,"need_shipping_address":
            writer.WriteValue(this.need_shipping_address);
            writer.WriteSpan(StringPool.Slice(10800, 33)); // ,"send_phone_number_to_provider":
            writer.WriteValue(this.send_phone_number_to_provider);
            writer.WriteSpan(StringPool.Slice(10840, 34)); // ,"send_email_address_to_provider":
            writer.WriteValue(this.send_email_address_to_provider);
            writer.WriteSpan(StringPool.Slice(10880, 15)); // ,"is_flexible":
            writer.WriteValue(this.is_flexible);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class OrderInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(10896, 20)); // {"@type":"orderInfo"
            writer.WriteSpan(StringPool.Slice(9624, 8)); // ,"name":
            writer.WriteValue(this.name);
            writer.WriteSpan(StringPool.Slice(696, 16)); // ,"phone_number":
            writer.WriteValue(this.phone_number);
            writer.WriteSpan(StringPool.Slice(9128, 17)); // ,"email_address":
            writer.WriteValue(this.email_address);
            if (this.shipping_address != null)
            {
                writer.WriteSpan(StringPool.Slice(10920, 20)); // ,"shipping_address":
                writer.WriteValue(this.shipping_address);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ShippingOption
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(10944, 25)); // {"@type":"shippingOption"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            if (this.price_parts != null)
            {
                writer.WriteSpan(StringPool.Slice(10672, 15)); // ,"price_parts":
                writer.WriteArray(this.price_parts);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SavedCredentials
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(10976, 27)); // {"@type":"savedCredentials"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputCredentialsSaved
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(11008, 32)); // {"@type":"inputCredentialsSaved"
            writer.WriteSpan(StringPool.Slice(11040, 24)); // ,"saved_credentials_id":
            writer.WriteValue(this.saved_credentials_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputCredentialsNew
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(11064, 30)); // {"@type":"inputCredentialsNew"
            writer.WriteSpan(StringPool.Slice(8488, 8)); // ,"data":
            writer.WriteValue(this.data);
            writer.WriteSpan(StringPool.Slice(11096, 14)); // ,"allow_save":
            writer.WriteValue(this.allow_save);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputCredentialsAndroidPay
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(11112, 37)); // {"@type":"inputCredentialsAndroidPay"
            writer.WriteSpan(StringPool.Slice(8488, 8)); // ,"data":
            writer.WriteValue(this.data);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputCredentialsApplePay
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(11152, 35)); // {"@type":"inputCredentialsApplePay"
            writer.WriteSpan(StringPool.Slice(8488, 8)); // ,"data":
            writer.WriteValue(this.data);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PaymentsProviderStripe
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(11192, 33)); // {"@type":"paymentsProviderStripe"
            writer.WriteSpan(StringPool.Slice(11232, 19)); // ,"publishable_key":
            writer.WriteValue(this.publishable_key);
            writer.WriteSpan(StringPool.Slice(11256, 16)); // ,"need_country":
            writer.WriteValue(this.need_country);
            writer.WriteSpan(StringPool.Slice(11272, 20)); // ,"need_postal_code":
            writer.WriteValue(this.need_postal_code);
            writer.WriteSpan(StringPool.Slice(11296, 24)); // ,"need_cardholder_name":
            writer.WriteValue(this.need_cardholder_name);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PaymentForm
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(11320, 22)); // {"@type":"paymentForm"
            if (this.invoice != null)
            {
                writer.WriteSpan(StringPool.Slice(11344, 11)); // ,"invoice":
                writer.WriteValue(this.invoice);
            }
            writer.WriteSpan(StringPool.Slice(8432, 7)); // ,"url":
            writer.WriteValue(this.url);
            if (this.payments_provider != null)
            {
                writer.WriteSpan(StringPool.Slice(11360, 21)); // ,"payments_provider":
                writer.WriteValue(this.payments_provider);
            }
            if (this.saved_order_info != null)
            {
                writer.WriteSpan(StringPool.Slice(11384, 20)); // ,"saved_order_info":
                writer.WriteValue(this.saved_order_info);
            }
            if (this.saved_credentials != null)
            {
                writer.WriteSpan(StringPool.Slice(11408, 21)); // ,"saved_credentials":
                writer.WriteValue(this.saved_credentials);
            }
            writer.WriteSpan(StringPool.Slice(11432, 24)); // ,"can_save_credentials":
            writer.WriteValue(this.can_save_credentials);
            writer.WriteSpan(StringPool.Slice(11456, 17)); // ,"need_password":
            writer.WriteValue(this.need_password);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ValidatedOrderInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(11480, 29)); // {"@type":"validatedOrderInfo"
            writer.WriteSpan(StringPool.Slice(11512, 17)); // ,"order_info_id":
            writer.WriteValue(this.order_info_id);
            if (this.shipping_options != null)
            {
                writer.WriteSpan(StringPool.Slice(11536, 20)); // ,"shipping_options":
                writer.WriteArray(this.shipping_options);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PaymentResult
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(11560, 24)); // {"@type":"paymentResult"
            writer.WriteSpan(StringPool.Slice(11584, 11)); // ,"success":
            writer.WriteValue(this.success);
            writer.WriteSpan(StringPool.Slice(11600, 20)); // ,"verification_url":
            writer.WriteValue(this.verification_url);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PaymentReceipt
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(11624, 25)); // {"@type":"paymentReceipt"
            writer.WriteSpan(StringPool.Slice(5816, 8)); // ,"date":
            writer.WriteValue(this.date);
            writer.WriteSpan(StringPool.Slice(11656, 29)); // ,"payments_provider_user_id":
            writer.WriteValue(this.payments_provider_user_id);
            if (this.invoice != null)
            {
                writer.WriteSpan(StringPool.Slice(11344, 11)); // ,"invoice":
                writer.WriteValue(this.invoice);
            }
            if (this.order_info != null)
            {
                writer.WriteSpan(StringPool.Slice(11688, 14)); // ,"order_info":
                writer.WriteValue(this.order_info);
            }
            if (this.shipping_option != null)
            {
                writer.WriteSpan(StringPool.Slice(11704, 19)); // ,"shipping_option":
                writer.WriteValue(this.shipping_option);
            }
            writer.WriteSpan(StringPool.Slice(11728, 21)); // ,"credentials_title":
            writer.WriteValue(this.credentials_title);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DatedFile
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(11752, 20)); // {"@type":"datedFile"
            if (this.file != null)
            {
                writer.WriteSpan(StringPool.Slice(11776, 8)); // ,"file":
                writer.WriteValue(this.file);
            }
            writer.WriteSpan(StringPool.Slice(5816, 8)); // ,"date":
            writer.WriteValue(this.date);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementTypePersonalDetails
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(11784, 45)); // {"@type":"passportElementTypePersonalDetails"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementTypePassport
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(11832, 38)); // {"@type":"passportElementTypePassport"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementTypeDriverLicense
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(11872, 43)); // {"@type":"passportElementTypeDriverLicense"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementTypeIdentityCard
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(11920, 42)); // {"@type":"passportElementTypeIdentityCard"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementTypeInternalPassport
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(11968, 46)); // {"@type":"passportElementTypeInternalPassport"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementTypeAddress
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(12016, 37)); // {"@type":"passportElementTypeAddress"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementTypeUtilityBill
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(12056, 41)); // {"@type":"passportElementTypeUtilityBill"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementTypeBankStatement
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(12104, 43)); // {"@type":"passportElementTypeBankStatement"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementTypeRentalAgreement
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(12152, 45)); // {"@type":"passportElementTypeRentalAgreement"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementTypePassportRegistration
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(12200, 50)); // {"@type":"passportElementTypePassportRegistration"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementTypeTemporaryRegistration
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(12256, 51)); // {"@type":"passportElementTypeTemporaryRegistration"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementTypePhoneNumber
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(12312, 41)); // {"@type":"passportElementTypePhoneNumber"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementTypeEmailAddress
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(12360, 42)); // {"@type":"passportElementTypeEmailAddress"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Date
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(12408, 15)); // {"@type":"date"
            writer.WriteSpan(StringPool.Slice(12424, 7)); // ,"day":
            writer.WriteValue(this.day);
            writer.WriteSpan(StringPool.Slice(12432, 9)); // ,"month":
            writer.WriteValue(this.month);
            writer.WriteSpan(StringPool.Slice(12448, 8)); // ,"year":
            writer.WriteValue(this.year);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PersonalDetails
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(12456, 26)); // {"@type":"personalDetails"
            writer.WriteSpan(StringPool.Slice(3192, 14)); // ,"first_name":
            writer.WriteValue(this.first_name);
            writer.WriteSpan(StringPool.Slice(12488, 15)); // ,"middle_name":
            writer.WriteValue(this.middle_name);
            writer.WriteSpan(StringPool.Slice(3208, 13)); // ,"last_name":
            writer.WriteValue(this.last_name);
            writer.WriteSpan(StringPool.Slice(12504, 21)); // ,"native_first_name":
            writer.WriteValue(this.native_first_name);
            writer.WriteSpan(StringPool.Slice(12528, 22)); // ,"native_middle_name":
            writer.WriteValue(this.native_middle_name);
            writer.WriteSpan(StringPool.Slice(12552, 20)); // ,"native_last_name":
            writer.WriteValue(this.native_last_name);
            if (this.birthdate != null)
            {
                writer.WriteSpan(StringPool.Slice(12576, 13)); // ,"birthdate":
                writer.WriteValue(this.birthdate);
            }
            writer.WriteSpan(StringPool.Slice(12592, 10)); // ,"gender":
            writer.WriteValue(this.gender);
            writer.WriteSpan(StringPool.Slice(10496, 16)); // ,"country_code":
            writer.WriteValue(this.country_code);
            writer.WriteSpan(StringPool.Slice(12608, 26)); // ,"residence_country_code":
            writer.WriteValue(this.residence_country_code);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class IdentityDocument
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(12640, 27)); // {"@type":"identityDocument"
            writer.WriteSpan(StringPool.Slice(12672, 10)); // ,"number":
            writer.WriteValue(this.number);
            if (this.expiry_date != null)
            {
                writer.WriteSpan(StringPool.Slice(12688, 15)); // ,"expiry_date":
                writer.WriteValue(this.expiry_date);
            }
            if (this.front_side != null)
            {
                writer.WriteSpan(StringPool.Slice(12704, 14)); // ,"front_side":
                writer.WriteValue(this.front_side);
            }
            if (this.reverse_side != null)
            {
                writer.WriteSpan(StringPool.Slice(12720, 16)); // ,"reverse_side":
                writer.WriteValue(this.reverse_side);
            }
            if (this.selfie != null)
            {
                writer.WriteSpan(StringPool.Slice(12736, 10)); // ,"selfie":
                writer.WriteValue(this.selfie);
            }
            if (this.translation != null)
            {
                writer.WriteSpan(StringPool.Slice(12752, 15)); // ,"translation":
                writer.WriteArray(this.translation);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputIdentityDocument
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(12768, 32)); // {"@type":"inputIdentityDocument"
            writer.WriteSpan(StringPool.Slice(12672, 10)); // ,"number":
            writer.WriteValue(this.number);
            if (this.expiry_date != null)
            {
                writer.WriteSpan(StringPool.Slice(12688, 15)); // ,"expiry_date":
                writer.WriteValue(this.expiry_date);
            }
            if (this.front_side != null)
            {
                writer.WriteSpan(StringPool.Slice(12704, 14)); // ,"front_side":
                writer.WriteValue(this.front_side);
            }
            if (this.reverse_side != null)
            {
                writer.WriteSpan(StringPool.Slice(12720, 16)); // ,"reverse_side":
                writer.WriteValue(this.reverse_side);
            }
            if (this.selfie != null)
            {
                writer.WriteSpan(StringPool.Slice(12736, 10)); // ,"selfie":
                writer.WriteValue(this.selfie);
            }
            if (this.translation != null)
            {
                writer.WriteSpan(StringPool.Slice(12752, 15)); // ,"translation":
                writer.WriteArray(this.translation);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PersonalDocument
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(12800, 27)); // {"@type":"personalDocument"
            if (this.files != null)
            {
                writer.WriteSpan(StringPool.Slice(12832, 9)); // ,"files":
                writer.WriteArray(this.files);
            }
            if (this.translation != null)
            {
                writer.WriteSpan(StringPool.Slice(12752, 15)); // ,"translation":
                writer.WriteArray(this.translation);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPersonalDocument
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(12848, 32)); // {"@type":"inputPersonalDocument"
            if (this.files != null)
            {
                writer.WriteSpan(StringPool.Slice(12832, 9)); // ,"files":
                writer.WriteArray(this.files);
            }
            if (this.translation != null)
            {
                writer.WriteSpan(StringPool.Slice(12752, 15)); // ,"translation":
                writer.WriteArray(this.translation);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementPersonalDetails
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(12880, 41)); // {"@type":"passportElementPersonalDetails"
            if (this.personal_details != null)
            {
                writer.WriteSpan(StringPool.Slice(12928, 20)); // ,"personal_details":
                writer.WriteValue(this.personal_details);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementPassport
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(12952, 34)); // {"@type":"passportElementPassport"
            if (this.passport != null)
            {
                writer.WriteSpan(StringPool.Slice(12992, 12)); // ,"passport":
                writer.WriteValue(this.passport);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementDriverLicense
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(13008, 39)); // {"@type":"passportElementDriverLicense"
            if (this.driver_license != null)
            {
                writer.WriteSpan(StringPool.Slice(13048, 18)); // ,"driver_license":
                writer.WriteValue(this.driver_license);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementIdentityCard
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(13072, 38)); // {"@type":"passportElementIdentityCard"
            if (this.identity_card != null)
            {
                writer.WriteSpan(StringPool.Slice(13112, 17)); // ,"identity_card":
                writer.WriteValue(this.identity_card);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementInternalPassport
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(13136, 42)); // {"@type":"passportElementInternalPassport"
            if (this.internal_passport != null)
            {
                writer.WriteSpan(StringPool.Slice(13184, 21)); // ,"internal_passport":
                writer.WriteValue(this.internal_passport);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementAddress
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(13208, 33)); // {"@type":"passportElementAddress"
            if (this.address != null)
            {
                writer.WriteSpan(StringPool.Slice(3344, 11)); // ,"address":
                writer.WriteValue(this.address);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementUtilityBill
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(13248, 37)); // {"@type":"passportElementUtilityBill"
            if (this.utility_bill != null)
            {
                writer.WriteSpan(StringPool.Slice(13288, 16)); // ,"utility_bill":
                writer.WriteValue(this.utility_bill);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementBankStatement
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(13304, 39)); // {"@type":"passportElementBankStatement"
            if (this.bank_statement != null)
            {
                writer.WriteSpan(StringPool.Slice(13344, 18)); // ,"bank_statement":
                writer.WriteValue(this.bank_statement);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementRentalAgreement
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(13368, 41)); // {"@type":"passportElementRentalAgreement"
            if (this.rental_agreement != null)
            {
                writer.WriteSpan(StringPool.Slice(13416, 20)); // ,"rental_agreement":
                writer.WriteValue(this.rental_agreement);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementPassportRegistration
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(13440, 46)); // {"@type":"passportElementPassportRegistration"
            if (this.passport_registration != null)
            {
                writer.WriteSpan(StringPool.Slice(13488, 25)); // ,"passport_registration":
                writer.WriteValue(this.passport_registration);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementTemporaryRegistration
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(13520, 47)); // {"@type":"passportElementTemporaryRegistration"
            if (this.temporary_registration != null)
            {
                writer.WriteSpan(StringPool.Slice(13568, 26)); // ,"temporary_registration":
                writer.WriteValue(this.temporary_registration);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementPhoneNumber
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(13600, 37)); // {"@type":"passportElementPhoneNumber"
            writer.WriteSpan(StringPool.Slice(696, 16)); // ,"phone_number":
            writer.WriteValue(this.phone_number);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementEmailAddress
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(13640, 38)); // {"@type":"passportElementEmailAddress"
            writer.WriteSpan(StringPool.Slice(9128, 17)); // ,"email_address":
            writer.WriteValue(this.email_address);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementPersonalDetails
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(13680, 46)); // {"@type":"inputPassportElementPersonalDetails"
            if (this.personal_details != null)
            {
                writer.WriteSpan(StringPool.Slice(12928, 20)); // ,"personal_details":
                writer.WriteValue(this.personal_details);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementPassport
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(13728, 39)); // {"@type":"inputPassportElementPassport"
            if (this.passport != null)
            {
                writer.WriteSpan(StringPool.Slice(12992, 12)); // ,"passport":
                writer.WriteValue(this.passport);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementDriverLicense
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(13768, 44)); // {"@type":"inputPassportElementDriverLicense"
            if (this.driver_license != null)
            {
                writer.WriteSpan(StringPool.Slice(13048, 18)); // ,"driver_license":
                writer.WriteValue(this.driver_license);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementIdentityCard
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(13816, 43)); // {"@type":"inputPassportElementIdentityCard"
            if (this.identity_card != null)
            {
                writer.WriteSpan(StringPool.Slice(13112, 17)); // ,"identity_card":
                writer.WriteValue(this.identity_card);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementInternalPassport
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(13864, 47)); // {"@type":"inputPassportElementInternalPassport"
            if (this.internal_passport != null)
            {
                writer.WriteSpan(StringPool.Slice(13184, 21)); // ,"internal_passport":
                writer.WriteValue(this.internal_passport);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementAddress
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(13912, 38)); // {"@type":"inputPassportElementAddress"
            if (this.address != null)
            {
                writer.WriteSpan(StringPool.Slice(3344, 11)); // ,"address":
                writer.WriteValue(this.address);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementUtilityBill
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(13952, 42)); // {"@type":"inputPassportElementUtilityBill"
            if (this.utility_bill != null)
            {
                writer.WriteSpan(StringPool.Slice(13288, 16)); // ,"utility_bill":
                writer.WriteValue(this.utility_bill);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementBankStatement
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(14000, 44)); // {"@type":"inputPassportElementBankStatement"
            if (this.bank_statement != null)
            {
                writer.WriteSpan(StringPool.Slice(13344, 18)); // ,"bank_statement":
                writer.WriteValue(this.bank_statement);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementRentalAgreement
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(14048, 46)); // {"@type":"inputPassportElementRentalAgreement"
            if (this.rental_agreement != null)
            {
                writer.WriteSpan(StringPool.Slice(13416, 20)); // ,"rental_agreement":
                writer.WriteValue(this.rental_agreement);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementPassportRegistration
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(14096, 51)); // {"@type":"inputPassportElementPassportRegistration"
            if (this.passport_registration != null)
            {
                writer.WriteSpan(StringPool.Slice(13488, 25)); // ,"passport_registration":
                writer.WriteValue(this.passport_registration);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementTemporaryRegistration
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(14152, 52)); // {"@type":"inputPassportElementTemporaryRegistration"
            if (this.temporary_registration != null)
            {
                writer.WriteSpan(StringPool.Slice(13568, 26)); // ,"temporary_registration":
                writer.WriteValue(this.temporary_registration);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementPhoneNumber
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(14208, 42)); // {"@type":"inputPassportElementPhoneNumber"
            writer.WriteSpan(StringPool.Slice(696, 16)); // ,"phone_number":
            writer.WriteValue(this.phone_number);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementEmailAddress
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(14256, 43)); // {"@type":"inputPassportElementEmailAddress"
            writer.WriteSpan(StringPool.Slice(9128, 17)); // ,"email_address":
            writer.WriteValue(this.email_address);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElements
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(14304, 27)); // {"@type":"passportElements"
            if (this.elements != null)
            {
                writer.WriteSpan(StringPool.Slice(14336, 12)); // ,"elements":
                writer.WriteArray(this.elements);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementErrorSourceUnspecified
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(14352, 48)); // {"@type":"passportElementErrorSourceUnspecified"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementErrorSourceDataField
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(14400, 46)); // {"@type":"passportElementErrorSourceDataField"
            writer.WriteSpan(StringPool.Slice(14448, 14)); // ,"field_name":
            writer.WriteValue(this.field_name);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementErrorSourceFrontSide
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(14464, 46)); // {"@type":"passportElementErrorSourceFrontSide"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementErrorSourceReverseSide
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(14512, 48)); // {"@type":"passportElementErrorSourceReverseSide"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementErrorSourceSelfie
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(14560, 43)); // {"@type":"passportElementErrorSourceSelfie"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementErrorSourceTranslationFile
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(14608, 52)); // {"@type":"passportElementErrorSourceTranslationFile"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementErrorSourceTranslationFiles
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(14664, 53)); // {"@type":"passportElementErrorSourceTranslationFiles"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementErrorSourceFile
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(14720, 41)); // {"@type":"passportElementErrorSourceFile"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementErrorSourceFiles
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(14768, 42)); // {"@type":"passportElementErrorSourceFiles"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportElementError
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(14816, 31)); // {"@type":"passportElementError"
            if (this.type != null)
            {
                writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
                writer.WriteValue(this.type);
            }
            writer.WriteSpan(StringPool.Slice(40, 11)); // ,"message":
            writer.WriteValue(this.message);
            if (this.source != null)
            {
                writer.WriteSpan(StringPool.Slice(14848, 10)); // ,"source":
                writer.WriteValue(this.source);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportSuitableElement
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(14864, 34)); // {"@type":"passportSuitableElement"
            if (this.type != null)
            {
                writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
                writer.WriteValue(this.type);
            }
            writer.WriteSpan(StringPool.Slice(14904, 22)); // ,"is_selfie_required":
            writer.WriteValue(this.is_selfie_required);
            writer.WriteSpan(StringPool.Slice(14928, 27)); // ,"is_translation_required":
            writer.WriteValue(this.is_translation_required);
            writer.WriteSpan(StringPool.Slice(14960, 27)); // ,"is_native_name_required":
            writer.WriteValue(this.is_native_name_required);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportRequiredElement
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(14992, 34)); // {"@type":"passportRequiredElement"
            if (this.suitable_elements != null)
            {
                writer.WriteSpan(StringPool.Slice(15032, 21)); // ,"suitable_elements":
                writer.WriteArray(this.suitable_elements);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PassportAuthorizationForm
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(15056, 36)); // {"@type":"passportAuthorizationForm"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            if (this.required_elements != null)
            {
                writer.WriteSpan(StringPool.Slice(15096, 21)); // ,"required_elements":
                writer.WriteArray(this.required_elements);
            }
            if (this.elements != null)
            {
                writer.WriteSpan(StringPool.Slice(14336, 12)); // ,"elements":
                writer.WriteArray(this.elements);
            }
            if (this.errors != null)
            {
                writer.WriteSpan(StringPool.Slice(15120, 10)); // ,"errors":
                writer.WriteArray(this.errors);
            }
            writer.WriteSpan(StringPool.Slice(15136, 22)); // ,"privacy_policy_url":
            writer.WriteValue(this.privacy_policy_url);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class EncryptedCredentials
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(15160, 31)); // {"@type":"encryptedCredentials"
            if (this.data != null)
            {
                writer.WriteSpan(StringPool.Slice(8488, 8)); // ,"data":
                writer.WriteBytesValue(this.data);
            }
            if (this.hash != null)
            {
                writer.WriteSpan(StringPool.Slice(15192, 8)); // ,"hash":
                writer.WriteBytesValue(this.hash);
            }
            if (this.secret != null)
            {
                writer.WriteSpan(StringPool.Slice(15200, 10)); // ,"secret":
                writer.WriteBytesValue(this.secret);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class EncryptedPassportElement
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(15216, 35)); // {"@type":"encryptedPassportElement"
            if (this.type != null)
            {
                writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
                writer.WriteValue(this.type);
            }
            if (this.data != null)
            {
                writer.WriteSpan(StringPool.Slice(8488, 8)); // ,"data":
                writer.WriteBytesValue(this.data);
            }
            if (this.front_side != null)
            {
                writer.WriteSpan(StringPool.Slice(12704, 14)); // ,"front_side":
                writer.WriteValue(this.front_side);
            }
            if (this.reverse_side != null)
            {
                writer.WriteSpan(StringPool.Slice(12720, 16)); // ,"reverse_side":
                writer.WriteValue(this.reverse_side);
            }
            if (this.selfie != null)
            {
                writer.WriteSpan(StringPool.Slice(12736, 10)); // ,"selfie":
                writer.WriteValue(this.selfie);
            }
            if (this.translation != null)
            {
                writer.WriteSpan(StringPool.Slice(12752, 15)); // ,"translation":
                writer.WriteArray(this.translation);
            }
            if (this.files != null)
            {
                writer.WriteSpan(StringPool.Slice(12832, 9)); // ,"files":
                writer.WriteArray(this.files);
            }
            writer.WriteSpan(StringPool.Slice(15256, 9)); // ,"value":
            writer.WriteValue(this.value);
            writer.WriteSpan(StringPool.Slice(15192, 8)); // ,"hash":
            writer.WriteValue(this.hash);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementErrorSourceUnspecified
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(15272, 53)); // {"@type":"inputPassportElementErrorSourceUnspecified"
            if (this.element_hash != null)
            {
                writer.WriteSpan(StringPool.Slice(15328, 16)); // ,"element_hash":
                writer.WriteBytesValue(this.element_hash);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementErrorSourceDataField
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(15344, 51)); // {"@type":"inputPassportElementErrorSourceDataField"
            writer.WriteSpan(StringPool.Slice(14448, 14)); // ,"field_name":
            writer.WriteValue(this.field_name);
            if (this.data_hash != null)
            {
                writer.WriteSpan(StringPool.Slice(15400, 13)); // ,"data_hash":
                writer.WriteBytesValue(this.data_hash);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementErrorSourceFrontSide
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(15416, 51)); // {"@type":"inputPassportElementErrorSourceFrontSide"
            if (this.file_hash != null)
            {
                writer.WriteSpan(StringPool.Slice(15472, 13)); // ,"file_hash":
                writer.WriteBytesValue(this.file_hash);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementErrorSourceReverseSide
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(15488, 53)); // {"@type":"inputPassportElementErrorSourceReverseSide"
            if (this.file_hash != null)
            {
                writer.WriteSpan(StringPool.Slice(15472, 13)); // ,"file_hash":
                writer.WriteBytesValue(this.file_hash);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementErrorSourceSelfie
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(15544, 48)); // {"@type":"inputPassportElementErrorSourceSelfie"
            if (this.file_hash != null)
            {
                writer.WriteSpan(StringPool.Slice(15472, 13)); // ,"file_hash":
                writer.WriteBytesValue(this.file_hash);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementErrorSourceTranslationFile
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(15592, 57)); // {"@type":"inputPassportElementErrorSourceTranslationFile"
            if (this.file_hash != null)
            {
                writer.WriteSpan(StringPool.Slice(15472, 13)); // ,"file_hash":
                writer.WriteBytesValue(this.file_hash);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementErrorSourceTranslationFiles
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(15656, 58)); // {"@type":"inputPassportElementErrorSourceTranslationFiles"
            if (this.file_hashes != null)
            {
                writer.WriteSpan(StringPool.Slice(15720, 15)); // ,"file_hashes":
                writer.WriteArray(this.file_hashes);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementErrorSourceFile
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(15736, 46)); // {"@type":"inputPassportElementErrorSourceFile"
            if (this.file_hash != null)
            {
                writer.WriteSpan(StringPool.Slice(15472, 13)); // ,"file_hash":
                writer.WriteBytesValue(this.file_hash);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementErrorSourceFiles
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(15784, 47)); // {"@type":"inputPassportElementErrorSourceFiles"
            if (this.file_hashes != null)
            {
                writer.WriteSpan(StringPool.Slice(15720, 15)); // ,"file_hashes":
                writer.WriteArray(this.file_hashes);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputPassportElementError
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(15832, 36)); // {"@type":"inputPassportElementError"
            if (this.type != null)
            {
                writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
                writer.WriteValue(this.type);
            }
            writer.WriteSpan(StringPool.Slice(40, 11)); // ,"message":
            writer.WriteValue(this.message);
            if (this.source != null)
            {
                writer.WriteSpan(StringPool.Slice(14848, 10)); // ,"source":
                writer.WriteValue(this.source);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageText
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(15872, 22)); // {"@type":"messageText"
            if (this.text != null)
            {
                writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
                writer.WriteValue(this.text);
            }
            if (this.web_page != null)
            {
                writer.WriteSpan(StringPool.Slice(15896, 12)); // ,"web_page":
                writer.WriteValue(this.web_page);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageAnimation
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(15912, 27)); // {"@type":"messageAnimation"
            if (this.animation != null)
            {
                writer.WriteSpan(StringPool.Slice(2720, 13)); // ,"animation":
                writer.WriteValue(this.animation);
            }
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            writer.WriteSpan(StringPool.Slice(15944, 13)); // ,"is_secret":
            writer.WriteValue(this.is_secret);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageAudio
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(15960, 23)); // {"@type":"messageAudio"
            if (this.audio != null)
            {
                writer.WriteSpan(StringPool.Slice(2816, 9)); // ,"audio":
                writer.WriteValue(this.audio);
            }
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageDocument
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(15984, 26)); // {"@type":"messageDocument"
            if (this.document != null)
            {
                writer.WriteSpan(StringPool.Slice(2856, 12)); // ,"document":
                writer.WriteValue(this.document);
            }
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessagePhoto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16016, 23)); // {"@type":"messagePhoto"
            if (this.photo != null)
            {
                writer.WriteSpan(StringPool.Slice(2384, 9)); // ,"photo":
                writer.WriteValue(this.photo);
            }
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            writer.WriteSpan(StringPool.Slice(15944, 13)); // ,"is_secret":
            writer.WriteValue(this.is_secret);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageExpiredPhoto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16040, 30)); // {"@type":"messageExpiredPhoto"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageSticker
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16072, 25)); // {"@type":"messageSticker"
            if (this.sticker != null)
            {
                writer.WriteSpan(StringPool.Slice(3016, 11)); // ,"sticker":
                writer.WriteValue(this.sticker);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageVideo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16104, 23)); // {"@type":"messageVideo"
            if (this.video != null)
            {
                writer.WriteSpan(StringPool.Slice(3072, 9)); // ,"video":
                writer.WriteValue(this.video);
            }
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            writer.WriteSpan(StringPool.Slice(15944, 13)); // ,"is_secret":
            writer.WriteValue(this.is_secret);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageExpiredVideo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16128, 30)); // {"@type":"messageExpiredVideo"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageVideoNote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16160, 27)); // {"@type":"messageVideoNote"
            if (this.video_note != null)
            {
                writer.WriteSpan(StringPool.Slice(10416, 14)); // ,"video_note":
                writer.WriteValue(this.video_note);
            }
            writer.WriteSpan(StringPool.Slice(16192, 13)); // ,"is_viewed":
            writer.WriteValue(this.is_viewed);
            writer.WriteSpan(StringPool.Slice(15944, 13)); // ,"is_secret":
            writer.WriteValue(this.is_secret);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageVoiceNote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16208, 27)); // {"@type":"messageVoiceNote"
            if (this.voice_note != null)
            {
                writer.WriteSpan(StringPool.Slice(10432, 14)); // ,"voice_note":
                writer.WriteValue(this.voice_note);
            }
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            writer.WriteSpan(StringPool.Slice(16240, 15)); // ,"is_listened":
            writer.WriteValue(this.is_listened);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageLocation
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16256, 26)); // {"@type":"messageLocation"
            if (this.location != null)
            {
                writer.WriteSpan(StringPool.Slice(3328, 12)); // ,"location":
                writer.WriteValue(this.location);
            }
            writer.WriteSpan(StringPool.Slice(16288, 15)); // ,"live_period":
            writer.WriteValue(this.live_period);
            writer.WriteSpan(StringPool.Slice(16304, 14)); // ,"expires_in":
            writer.WriteValue(this.expires_in);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageVenue
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16320, 23)); // {"@type":"messageVenue"
            if (this.venue != null)
            {
                writer.WriteSpan(StringPool.Slice(16344, 9)); // ,"venue":
                writer.WriteValue(this.venue);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageContact
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16360, 25)); // {"@type":"messageContact"
            if (this.contact != null)
            {
                writer.WriteSpan(StringPool.Slice(16392, 11)); // ,"contact":
                writer.WriteValue(this.contact);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageGame
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16408, 22)); // {"@type":"messageGame"
            if (this.game != null)
            {
                writer.WriteSpan(StringPool.Slice(16432, 8)); // ,"game":
                writer.WriteValue(this.game);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageInvoice
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16440, 25)); // {"@type":"messageInvoice"
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(3408, 15)); // ,"description":
            writer.WriteValue(this.description);
            if (this.photo != null)
            {
                writer.WriteSpan(StringPool.Slice(2384, 9)); // ,"photo":
                writer.WriteValue(this.photo);
            }
            writer.WriteSpan(StringPool.Slice(10656, 12)); // ,"currency":
            writer.WriteValue(this.currency);
            writer.WriteSpan(StringPool.Slice(16472, 16)); // ,"total_amount":
            writer.WriteValue(this.total_amount);
            writer.WriteSpan(StringPool.Slice(16488, 19)); // ,"start_parameter":
            writer.WriteValue(this.start_parameter);
            writer.WriteSpan(StringPool.Slice(10688, 11)); // ,"is_test":
            writer.WriteValue(this.is_test);
            writer.WriteSpan(StringPool.Slice(10768, 25)); // ,"need_shipping_address":
            writer.WriteValue(this.need_shipping_address);
            writer.WriteSpan(StringPool.Slice(16512, 22)); // ,"receipt_message_id":
            writer.WriteValue(this.receipt_message_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageCall
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16536, 22)); // {"@type":"messageCall"
            if (this.discard_reason != null)
            {
                writer.WriteSpan(StringPool.Slice(16560, 18)); // ,"discard_reason":
                writer.WriteValue(this.discard_reason);
            }
            writer.WriteSpan(StringPool.Slice(2656, 12)); // ,"duration":
            writer.WriteValue(this.duration);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageBasicGroupChatCreate
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16584, 38)); // {"@type":"messageBasicGroupChatCreate"
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            if (this.member_user_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(8184, 19)); // ,"member_user_ids":
                writer.WriteArray(this.member_user_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageSupergroupChatCreate
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16624, 38)); // {"@type":"messageSupergroupChatCreate"
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageChatChangeTitle
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16664, 33)); // {"@type":"messageChatChangeTitle"
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageChatChangePhoto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16704, 33)); // {"@type":"messageChatChangePhoto"
            if (this.photo != null)
            {
                writer.WriteSpan(StringPool.Slice(2384, 9)); // ,"photo":
                writer.WriteValue(this.photo);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageChatDeletePhoto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16744, 33)); // {"@type":"messageChatDeletePhoto"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageChatAddMembers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16784, 32)); // {"@type":"messageChatAddMembers"
            if (this.member_user_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(8184, 19)); // ,"member_user_ids":
                writer.WriteArray(this.member_user_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageChatJoinByLink
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16816, 32)); // {"@type":"messageChatJoinByLink"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageChatDeleteMember
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16848, 34)); // {"@type":"messageChatDeleteMember"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageChatUpgradeTo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16888, 31)); // {"@type":"messageChatUpgradeTo"
            writer.WriteSpan(StringPool.Slice(7640, 17)); // ,"supergroup_id":
            writer.WriteValue(this.supergroup_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageChatUpgradeFrom
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16920, 33)); // {"@type":"messageChatUpgradeFrom"
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(7584, 18)); // ,"basic_group_id":
            writer.WriteValue(this.basic_group_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessagePinMessage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16960, 28)); // {"@type":"messagePinMessage"
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageScreenshotTaken
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(16992, 33)); // {"@type":"messageScreenshotTaken"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageChatSetTtl
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17032, 28)); // {"@type":"messageChatSetTtl"
            writer.WriteSpan(StringPool.Slice(6360, 7)); // ,"ttl":
            writer.WriteValue(this.ttl);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageCustomServiceAction
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17064, 37)); // {"@type":"messageCustomServiceAction"
            writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
            writer.WriteValue(this.text);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageGameScore
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17104, 27)); // {"@type":"messageGameScore"
            writer.WriteSpan(StringPool.Slice(17136, 19)); // ,"game_message_id":
            writer.WriteValue(this.game_message_id);
            writer.WriteSpan(StringPool.Slice(17160, 11)); // ,"game_id":
            writer.WriteInt64String(this.game_id);
            writer.WriteSpan(StringPool.Slice(17176, 9)); // ,"score":
            writer.WriteValue(this.score);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessagePaymentSuccessful
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17192, 35)); // {"@type":"messagePaymentSuccessful"
            writer.WriteSpan(StringPool.Slice(17232, 22)); // ,"invoice_message_id":
            writer.WriteValue(this.invoice_message_id);
            writer.WriteSpan(StringPool.Slice(10656, 12)); // ,"currency":
            writer.WriteValue(this.currency);
            writer.WriteSpan(StringPool.Slice(16472, 16)); // ,"total_amount":
            writer.WriteValue(this.total_amount);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessagePaymentSuccessfulBot
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17256, 38)); // {"@type":"messagePaymentSuccessfulBot"
            writer.WriteSpan(StringPool.Slice(17232, 22)); // ,"invoice_message_id":
            writer.WriteValue(this.invoice_message_id);
            writer.WriteSpan(StringPool.Slice(10656, 12)); // ,"currency":
            writer.WriteValue(this.currency);
            writer.WriteSpan(StringPool.Slice(16472, 16)); // ,"total_amount":
            writer.WriteValue(this.total_amount);
            if (this.invoice_payload != null)
            {
                writer.WriteSpan(StringPool.Slice(17296, 19)); // ,"invoice_payload":
                writer.WriteBytesValue(this.invoice_payload);
            }
            writer.WriteSpan(StringPool.Slice(17320, 22)); // ,"shipping_option_id":
            writer.WriteValue(this.shipping_option_id);
            if (this.order_info != null)
            {
                writer.WriteSpan(StringPool.Slice(11688, 14)); // ,"order_info":
                writer.WriteValue(this.order_info);
            }
            writer.WriteSpan(StringPool.Slice(17344, 30)); // ,"telegram_payment_charge_id":
            writer.WriteValue(this.telegram_payment_charge_id);
            writer.WriteSpan(StringPool.Slice(17376, 30)); // ,"provider_payment_charge_id":
            writer.WriteValue(this.provider_payment_charge_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageContactRegistered
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17408, 35)); // {"@type":"messageContactRegistered"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageWebsiteConnected
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17448, 34)); // {"@type":"messageWebsiteConnected"
            writer.WriteSpan(StringPool.Slice(17488, 15)); // ,"domain_name":
            writer.WriteValue(this.domain_name);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessagePassportDataSent
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17504, 34)); // {"@type":"messagePassportDataSent"
            if (this.types != null)
            {
                writer.WriteSpan(StringPool.Slice(17544, 9)); // ,"types":
                writer.WriteArray(this.types);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessagePassportDataReceived
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17560, 38)); // {"@type":"messagePassportDataReceived"
            if (this.elements != null)
            {
                writer.WriteSpan(StringPool.Slice(14336, 12)); // ,"elements":
                writer.WriteArray(this.elements);
            }
            if (this.credentials != null)
            {
                writer.WriteSpan(StringPool.Slice(17600, 15)); // ,"credentials":
                writer.WriteValue(this.credentials);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class MessageUnsupported
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17616, 29)); // {"@type":"messageUnsupported"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TextEntityTypeMention
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17648, 32)); // {"@type":"textEntityTypeMention"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TextEntityTypeHashtag
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17680, 32)); // {"@type":"textEntityTypeHashtag"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TextEntityTypeCashtag
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17712, 32)); // {"@type":"textEntityTypeCashtag"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TextEntityTypeBotCommand
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17744, 35)); // {"@type":"textEntityTypeBotCommand"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TextEntityTypeUrl
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17784, 28)); // {"@type":"textEntityTypeUrl"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TextEntityTypeEmailAddress
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17816, 37)); // {"@type":"textEntityTypeEmailAddress"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TextEntityTypeBold
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17856, 29)); // {"@type":"textEntityTypeBold"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TextEntityTypeItalic
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17888, 31)); // {"@type":"textEntityTypeItalic"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TextEntityTypeCode
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17920, 29)); // {"@type":"textEntityTypeCode"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TextEntityTypePre
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17952, 28)); // {"@type":"textEntityTypePre"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TextEntityTypePreCode
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(17984, 32)); // {"@type":"textEntityTypePreCode"
            writer.WriteSpan(StringPool.Slice(9496, 12)); // ,"language":
            writer.WriteValue(this.language);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TextEntityTypeTextUrl
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18016, 32)); // {"@type":"textEntityTypeTextUrl"
            writer.WriteSpan(StringPool.Slice(8432, 7)); // ,"url":
            writer.WriteValue(this.url);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TextEntityTypeMentionName
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18048, 36)); // {"@type":"textEntityTypeMentionName"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TextEntityTypePhoneNumber
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18088, 36)); // {"@type":"textEntityTypePhoneNumber"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputThumbnail
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18128, 25)); // {"@type":"inputThumbnail"
            if (this.thumbnail != null)
            {
                writer.WriteSpan(StringPool.Slice(2704, 13)); // ,"thumbnail":
                writer.WriteValue(this.thumbnail);
            }
            writer.WriteSpan(StringPool.Slice(2400, 9)); // ,"width":
            writer.WriteValue(this.width);
            writer.WriteSpan(StringPool.Slice(2416, 10)); // ,"height":
            writer.WriteValue(this.height);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputMessageText
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18160, 27)); // {"@type":"inputMessageText"
            if (this.text != null)
            {
                writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
                writer.WriteValue(this.text);
            }
            writer.WriteSpan(StringPool.Slice(18192, 28)); // ,"disable_web_page_preview":
            writer.WriteValue(this.disable_web_page_preview);
            writer.WriteSpan(StringPool.Slice(18224, 15)); // ,"clear_draft":
            writer.WriteValue(this.clear_draft);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputMessageAnimation
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18240, 32)); // {"@type":"inputMessageAnimation"
            if (this.animation != null)
            {
                writer.WriteSpan(StringPool.Slice(2720, 13)); // ,"animation":
                writer.WriteValue(this.animation);
            }
            if (this.thumbnail != null)
            {
                writer.WriteSpan(StringPool.Slice(2704, 13)); // ,"thumbnail":
                writer.WriteValue(this.thumbnail);
            }
            writer.WriteSpan(StringPool.Slice(2656, 12)); // ,"duration":
            writer.WriteValue(this.duration);
            writer.WriteSpan(StringPool.Slice(2400, 9)); // ,"width":
            writer.WriteValue(this.width);
            writer.WriteSpan(StringPool.Slice(2416, 10)); // ,"height":
            writer.WriteValue(this.height);
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputMessageAudio
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18272, 28)); // {"@type":"inputMessageAudio"
            if (this.audio != null)
            {
                writer.WriteSpan(StringPool.Slice(2816, 9)); // ,"audio":
                writer.WriteValue(this.audio);
            }
            if (this.album_cover_thumbnail != null)
            {
                writer.WriteSpan(StringPool.Slice(2784, 25)); // ,"album_cover_thumbnail":
                writer.WriteValue(this.album_cover_thumbnail);
            }
            writer.WriteSpan(StringPool.Slice(2656, 12)); // ,"duration":
            writer.WriteValue(this.duration);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(2768, 13)); // ,"performer":
            writer.WriteValue(this.performer);
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputMessageDocument
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18304, 31)); // {"@type":"inputMessageDocument"
            if (this.document != null)
            {
                writer.WriteSpan(StringPool.Slice(2856, 12)); // ,"document":
                writer.WriteValue(this.document);
            }
            if (this.thumbnail != null)
            {
                writer.WriteSpan(StringPool.Slice(2704, 13)); // ,"thumbnail":
                writer.WriteValue(this.thumbnail);
            }
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputMessagePhoto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18336, 28)); // {"@type":"inputMessagePhoto"
            if (this.photo != null)
            {
                writer.WriteSpan(StringPool.Slice(2384, 9)); // ,"photo":
                writer.WriteValue(this.photo);
            }
            if (this.thumbnail != null)
            {
                writer.WriteSpan(StringPool.Slice(2704, 13)); // ,"thumbnail":
                writer.WriteValue(this.thumbnail);
            }
            if (this.added_sticker_file_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(18368, 26)); // ,"added_sticker_file_ids":
                writer.WriteArray(this.added_sticker_file_ids);
            }
            writer.WriteSpan(StringPool.Slice(2400, 9)); // ,"width":
            writer.WriteValue(this.width);
            writer.WriteSpan(StringPool.Slice(2416, 10)); // ,"height":
            writer.WriteValue(this.height);
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            writer.WriteSpan(StringPool.Slice(6360, 7)); // ,"ttl":
            writer.WriteValue(this.ttl);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputMessageSticker
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18400, 30)); // {"@type":"inputMessageSticker"
            if (this.sticker != null)
            {
                writer.WriteSpan(StringPool.Slice(3016, 11)); // ,"sticker":
                writer.WriteValue(this.sticker);
            }
            if (this.thumbnail != null)
            {
                writer.WriteSpan(StringPool.Slice(2704, 13)); // ,"thumbnail":
                writer.WriteValue(this.thumbnail);
            }
            writer.WriteSpan(StringPool.Slice(2400, 9)); // ,"width":
            writer.WriteValue(this.width);
            writer.WriteSpan(StringPool.Slice(2416, 10)); // ,"height":
            writer.WriteValue(this.height);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputMessageVideo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18432, 28)); // {"@type":"inputMessageVideo"
            if (this.video != null)
            {
                writer.WriteSpan(StringPool.Slice(3072, 9)); // ,"video":
                writer.WriteValue(this.video);
            }
            if (this.thumbnail != null)
            {
                writer.WriteSpan(StringPool.Slice(2704, 13)); // ,"thumbnail":
                writer.WriteValue(this.thumbnail);
            }
            if (this.added_sticker_file_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(18368, 26)); // ,"added_sticker_file_ids":
                writer.WriteArray(this.added_sticker_file_ids);
            }
            writer.WriteSpan(StringPool.Slice(2656, 12)); // ,"duration":
            writer.WriteValue(this.duration);
            writer.WriteSpan(StringPool.Slice(2400, 9)); // ,"width":
            writer.WriteValue(this.width);
            writer.WriteSpan(StringPool.Slice(2416, 10)); // ,"height":
            writer.WriteValue(this.height);
            writer.WriteSpan(StringPool.Slice(3048, 22)); // ,"supports_streaming":
            writer.WriteValue(this.supports_streaming);
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            writer.WriteSpan(StringPool.Slice(6360, 7)); // ,"ttl":
            writer.WriteValue(this.ttl);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputMessageVideoNote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18464, 32)); // {"@type":"inputMessageVideoNote"
            if (this.video_note != null)
            {
                writer.WriteSpan(StringPool.Slice(10416, 14)); // ,"video_note":
                writer.WriteValue(this.video_note);
            }
            if (this.thumbnail != null)
            {
                writer.WriteSpan(StringPool.Slice(2704, 13)); // ,"thumbnail":
                writer.WriteValue(this.thumbnail);
            }
            writer.WriteSpan(StringPool.Slice(2656, 12)); // ,"duration":
            writer.WriteValue(this.duration);
            writer.WriteSpan(StringPool.Slice(496, 10)); // ,"length":
            writer.WriteValue(this.length);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputMessageVoiceNote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18496, 32)); // {"@type":"inputMessageVoiceNote"
            if (this.voice_note != null)
            {
                writer.WriteSpan(StringPool.Slice(10432, 14)); // ,"voice_note":
                writer.WriteValue(this.voice_note);
            }
            writer.WriteSpan(StringPool.Slice(2656, 12)); // ,"duration":
            writer.WriteValue(this.duration);
            if (this.waveform != null)
            {
                writer.WriteSpan(StringPool.Slice(3136, 12)); // ,"waveform":
                writer.WriteBytesValue(this.waveform);
            }
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputMessageLocation
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18528, 31)); // {"@type":"inputMessageLocation"
            if (this.location != null)
            {
                writer.WriteSpan(StringPool.Slice(3328, 12)); // ,"location":
                writer.WriteValue(this.location);
            }
            writer.WriteSpan(StringPool.Slice(16288, 15)); // ,"live_period":
            writer.WriteValue(this.live_period);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputMessageVenue
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18560, 28)); // {"@type":"inputMessageVenue"
            if (this.venue != null)
            {
                writer.WriteSpan(StringPool.Slice(16344, 9)); // ,"venue":
                writer.WriteValue(this.venue);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputMessageContact
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18592, 30)); // {"@type":"inputMessageContact"
            if (this.contact != null)
            {
                writer.WriteSpan(StringPool.Slice(16392, 11)); // ,"contact":
                writer.WriteValue(this.contact);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputMessageGame
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18624, 27)); // {"@type":"inputMessageGame"
            writer.WriteSpan(StringPool.Slice(18656, 15)); // ,"bot_user_id":
            writer.WriteValue(this.bot_user_id);
            writer.WriteSpan(StringPool.Slice(18672, 19)); // ,"game_short_name":
            writer.WriteValue(this.game_short_name);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputMessageInvoice
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18696, 30)); // {"@type":"inputMessageInvoice"
            if (this.invoice != null)
            {
                writer.WriteSpan(StringPool.Slice(11344, 11)); // ,"invoice":
                writer.WriteValue(this.invoice);
            }
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(3408, 15)); // ,"description":
            writer.WriteValue(this.description);
            writer.WriteSpan(StringPool.Slice(18728, 13)); // ,"photo_url":
            writer.WriteValue(this.photo_url);
            writer.WriteSpan(StringPool.Slice(18744, 14)); // ,"photo_size":
            writer.WriteValue(this.photo_size);
            writer.WriteSpan(StringPool.Slice(18760, 15)); // ,"photo_width":
            writer.WriteValue(this.photo_width);
            writer.WriteSpan(StringPool.Slice(18776, 16)); // ,"photo_height":
            writer.WriteValue(this.photo_height);
            if (this.payload != null)
            {
                writer.WriteSpan(StringPool.Slice(18792, 11)); // ,"payload":
                writer.WriteBytesValue(this.payload);
            }
            writer.WriteSpan(StringPool.Slice(18808, 18)); // ,"provider_token":
            writer.WriteValue(this.provider_token);
            writer.WriteSpan(StringPool.Slice(18832, 17)); // ,"provider_data":
            writer.WriteValue(this.provider_data);
            writer.WriteSpan(StringPool.Slice(16488, 19)); // ,"start_parameter":
            writer.WriteValue(this.start_parameter);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputMessageForwarded
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18856, 32)); // {"@type":"inputMessageForwarded"
            writer.WriteSpan(StringPool.Slice(18888, 16)); // ,"from_chat_id":
            writer.WriteValue(this.from_chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            writer.WriteSpan(StringPool.Slice(18904, 17)); // ,"in_game_share":
            writer.WriteValue(this.in_game_share);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchMessagesFilterEmpty
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18928, 36)); // {"@type":"searchMessagesFilterEmpty"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchMessagesFilterAnimation
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(18968, 40)); // {"@type":"searchMessagesFilterAnimation"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchMessagesFilterAudio
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19008, 36)); // {"@type":"searchMessagesFilterAudio"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchMessagesFilterDocument
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19048, 39)); // {"@type":"searchMessagesFilterDocument"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchMessagesFilterPhoto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19088, 36)); // {"@type":"searchMessagesFilterPhoto"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchMessagesFilterVideo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19128, 36)); // {"@type":"searchMessagesFilterVideo"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchMessagesFilterVoiceNote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19168, 40)); // {"@type":"searchMessagesFilterVoiceNote"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchMessagesFilterPhotoAndVideo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19208, 44)); // {"@type":"searchMessagesFilterPhotoAndVideo"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchMessagesFilterUrl
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19256, 34)); // {"@type":"searchMessagesFilterUrl"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchMessagesFilterChatPhoto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19296, 40)); // {"@type":"searchMessagesFilterChatPhoto"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchMessagesFilterCall
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19336, 35)); // {"@type":"searchMessagesFilterCall"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchMessagesFilterMissedCall
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19376, 41)); // {"@type":"searchMessagesFilterMissedCall"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchMessagesFilterVideoNote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19424, 40)); // {"@type":"searchMessagesFilterVideoNote"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchMessagesFilterVoiceAndVideoNote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19464, 48)); // {"@type":"searchMessagesFilterVoiceAndVideoNote"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchMessagesFilterMention
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19512, 38)); // {"@type":"searchMessagesFilterMention"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchMessagesFilterUnreadMention
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19552, 44)); // {"@type":"searchMessagesFilterUnreadMention"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatActionTyping
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19600, 27)); // {"@type":"chatActionTyping"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatActionRecordingVideo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19632, 35)); // {"@type":"chatActionRecordingVideo"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatActionUploadingVideo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19672, 35)); // {"@type":"chatActionUploadingVideo"
            writer.WriteSpan(StringPool.Slice(19712, 12)); // ,"progress":
            writer.WriteValue(this.progress);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatActionRecordingVoiceNote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19728, 39)); // {"@type":"chatActionRecordingVoiceNote"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatActionUploadingVoiceNote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19768, 39)); // {"@type":"chatActionUploadingVoiceNote"
            writer.WriteSpan(StringPool.Slice(19712, 12)); // ,"progress":
            writer.WriteValue(this.progress);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatActionUploadingPhoto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19808, 35)); // {"@type":"chatActionUploadingPhoto"
            writer.WriteSpan(StringPool.Slice(19712, 12)); // ,"progress":
            writer.WriteValue(this.progress);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatActionUploadingDocument
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19848, 38)); // {"@type":"chatActionUploadingDocument"
            writer.WriteSpan(StringPool.Slice(19712, 12)); // ,"progress":
            writer.WriteValue(this.progress);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatActionChoosingLocation
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19888, 37)); // {"@type":"chatActionChoosingLocation"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatActionChoosingContact
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19928, 36)); // {"@type":"chatActionChoosingContact"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatActionStartPlayingGame
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(19968, 37)); // {"@type":"chatActionStartPlayingGame"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatActionRecordingVideoNote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20008, 39)); // {"@type":"chatActionRecordingVideoNote"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatActionUploadingVideoNote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20048, 39)); // {"@type":"chatActionUploadingVideoNote"
            writer.WriteSpan(StringPool.Slice(19712, 12)); // ,"progress":
            writer.WriteValue(this.progress);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatActionCancel
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20088, 27)); // {"@type":"chatActionCancel"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserStatusEmpty
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20120, 26)); // {"@type":"userStatusEmpty"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserStatusOnline
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20152, 27)); // {"@type":"userStatusOnline"
            writer.WriteSpan(StringPool.Slice(20184, 11)); // ,"expires":
            writer.WriteValue(this.expires);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserStatusOffline
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20200, 28)); // {"@type":"userStatusOffline"
            writer.WriteSpan(StringPool.Slice(20232, 14)); // ,"was_online":
            writer.WriteValue(this.was_online);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserStatusRecently
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20248, 29)); // {"@type":"userStatusRecently"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserStatusLastWeek
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20280, 29)); // {"@type":"userStatusLastWeek"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserStatusLastMonth
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20312, 30)); // {"@type":"userStatusLastMonth"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Stickers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20344, 19)); // {"@type":"stickers"
            if (this.stickers != null)
            {
                writer.WriteSpan(StringPool.Slice(20368, 12)); // ,"stickers":
                writer.WriteArray(this.stickers);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class StickerEmojis
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20384, 24)); // {"@type":"stickerEmojis"
            if (this.emojis != null)
            {
                writer.WriteSpan(StringPool.Slice(20408, 10)); // ,"emojis":
                writer.WriteArray(this.emojis);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class StickerSet
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20424, 21)); // {"@type":"stickerSet"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteInt64String(this.id);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(9624, 8)); // ,"name":
            writer.WriteValue(this.name);
            writer.WriteSpan(StringPool.Slice(20448, 16)); // ,"is_installed":
            writer.WriteValue(this.is_installed);
            writer.WriteSpan(StringPool.Slice(20464, 15)); // ,"is_archived":
            writer.WriteValue(this.is_archived);
            writer.WriteSpan(StringPool.Slice(20480, 15)); // ,"is_official":
            writer.WriteValue(this.is_official);
            writer.WriteSpan(StringPool.Slice(20496, 12)); // ,"is_masks":
            writer.WriteValue(this.is_masks);
            writer.WriteSpan(StringPool.Slice(16192, 13)); // ,"is_viewed":
            writer.WriteValue(this.is_viewed);
            if (this.stickers != null)
            {
                writer.WriteSpan(StringPool.Slice(20368, 12)); // ,"stickers":
                writer.WriteArray(this.stickers);
            }
            if (this.emojis != null)
            {
                writer.WriteSpan(StringPool.Slice(20408, 10)); // ,"emojis":
                writer.WriteArray(this.emojis);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class StickerSetInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20512, 25)); // {"@type":"stickerSetInfo"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteInt64String(this.id);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(9624, 8)); // ,"name":
            writer.WriteValue(this.name);
            writer.WriteSpan(StringPool.Slice(20448, 16)); // ,"is_installed":
            writer.WriteValue(this.is_installed);
            writer.WriteSpan(StringPool.Slice(20464, 15)); // ,"is_archived":
            writer.WriteValue(this.is_archived);
            writer.WriteSpan(StringPool.Slice(20480, 15)); // ,"is_official":
            writer.WriteValue(this.is_official);
            writer.WriteSpan(StringPool.Slice(20496, 12)); // ,"is_masks":
            writer.WriteValue(this.is_masks);
            writer.WriteSpan(StringPool.Slice(16192, 13)); // ,"is_viewed":
            writer.WriteValue(this.is_viewed);
            writer.WriteSpan(StringPool.Slice(2136, 8)); // ,"size":
            writer.WriteValue(this.size);
            if (this.covers != null)
            {
                writer.WriteSpan(StringPool.Slice(20544, 10)); // ,"covers":
                writer.WriteArray(this.covers);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class StickerSets
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20560, 22)); // {"@type":"stickerSets"
            writer.WriteSpan(StringPool.Slice(4312, 15)); // ,"total_count":
            writer.WriteValue(this.total_count);
            if (this.sets != null)
            {
                writer.WriteSpan(StringPool.Slice(20584, 8)); // ,"sets":
                writer.WriteArray(this.sets);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CallDiscardReasonEmpty
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20592, 33)); // {"@type":"callDiscardReasonEmpty"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CallDiscardReasonMissed
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20632, 34)); // {"@type":"callDiscardReasonMissed"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CallDiscardReasonDeclined
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20672, 36)); // {"@type":"callDiscardReasonDeclined"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CallDiscardReasonDisconnected
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20712, 40)); // {"@type":"callDiscardReasonDisconnected"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CallDiscardReasonHungUp
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20752, 34)); // {"@type":"callDiscardReasonHungUp"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CallProtocol
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20792, 23)); // {"@type":"callProtocol"
            writer.WriteSpan(StringPool.Slice(20816, 11)); // ,"udp_p2p":
            writer.WriteValue(this.udp_p2p);
            writer.WriteSpan(StringPool.Slice(20832, 17)); // ,"udp_reflector":
            writer.WriteValue(this.udp_reflector);
            writer.WriteSpan(StringPool.Slice(20856, 13)); // ,"min_layer":
            writer.WriteValue(this.min_layer);
            writer.WriteSpan(StringPool.Slice(20872, 13)); // ,"max_layer":
            writer.WriteValue(this.max_layer);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CallConnection
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20888, 25)); // {"@type":"callConnection"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteInt64String(this.id);
            writer.WriteSpan(StringPool.Slice(20920, 6)); // ,"ip":
            writer.WriteValue(this.ip);
            writer.WriteSpan(StringPool.Slice(20928, 8)); // ,"ipv6":
            writer.WriteValue(this.ipv6);
            writer.WriteSpan(StringPool.Slice(20936, 8)); // ,"port":
            writer.WriteValue(this.port);
            if (this.peer_tag != null)
            {
                writer.WriteSpan(StringPool.Slice(20944, 12)); // ,"peer_tag":
                writer.WriteBytesValue(this.peer_tag);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CallId
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20960, 17)); // {"@type":"callId"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CallStatePending
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(20984, 27)); // {"@type":"callStatePending"
            writer.WriteSpan(StringPool.Slice(21016, 14)); // ,"is_created":
            writer.WriteValue(this.is_created);
            writer.WriteSpan(StringPool.Slice(21032, 15)); // ,"is_received":
            writer.WriteValue(this.is_received);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CallStateExchangingKeys
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(21048, 34)); // {"@type":"callStateExchangingKeys"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CallStateReady
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(21088, 25)); // {"@type":"callStateReady"
            if (this.protocol != null)
            {
                writer.WriteSpan(StringPool.Slice(21120, 12)); // ,"protocol":
                writer.WriteValue(this.protocol);
            }
            if (this.connections != null)
            {
                writer.WriteSpan(StringPool.Slice(21136, 15)); // ,"connections":
                writer.WriteArray(this.connections);
            }
            writer.WriteSpan(StringPool.Slice(21152, 10)); // ,"config":
            writer.WriteValue(this.config);
            if (this.encryption_key != null)
            {
                writer.WriteSpan(StringPool.Slice(21168, 18)); // ,"encryption_key":
                writer.WriteBytesValue(this.encryption_key);
            }
            if (this.emojis != null)
            {
                writer.WriteSpan(StringPool.Slice(20408, 10)); // ,"emojis":
                writer.WriteArray(this.emojis);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CallStateHangingUp
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(21192, 29)); // {"@type":"callStateHangingUp"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CallStateDiscarded
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(21224, 29)); // {"@type":"callStateDiscarded"
            if (this.reason != null)
            {
                writer.WriteSpan(StringPool.Slice(21256, 10)); // ,"reason":
                writer.WriteValue(this.reason);
            }
            writer.WriteSpan(StringPool.Slice(21272, 15)); // ,"need_rating":
            writer.WriteValue(this.need_rating);
            writer.WriteSpan(StringPool.Slice(21288, 26)); // ,"need_debug_information":
            writer.WriteValue(this.need_debug_information);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CallStateError
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(21320, 25)); // {"@type":"callStateError"
            if (this.error != null)
            {
                writer.WriteSpan(StringPool.Slice(21352, 9)); // ,"error":
                writer.WriteValue(this.error);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Call
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(21368, 15)); // {"@type":"call"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            writer.WriteSpan(StringPool.Slice(6744, 15)); // ,"is_outgoing":
            writer.WriteValue(this.is_outgoing);
            if (this.state != null)
            {
                writer.WriteSpan(StringPool.Slice(6328, 9)); // ,"state":
                writer.WriteValue(this.state);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Animations
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(21384, 21)); // {"@type":"animations"
            if (this.animations != null)
            {
                writer.WriteSpan(StringPool.Slice(21408, 14)); // ,"animations":
                writer.WriteArray(this.animations);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ImportedContacts
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(21424, 27)); // {"@type":"importedContacts"
            if (this.user_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(4360, 12)); // ,"user_ids":
                writer.WriteArray(this.user_ids);
            }
            if (this.importer_count != null)
            {
                writer.WriteSpan(StringPool.Slice(21456, 18)); // ,"importer_count":
                writer.WriteArray(this.importer_count);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputInlineQueryResultAnimatedGif
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(21480, 44)); // {"@type":"inputInlineQueryResultAnimatedGif"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(21528, 17)); // ,"thumbnail_url":
            writer.WriteValue(this.thumbnail_url);
            writer.WriteSpan(StringPool.Slice(21552, 11)); // ,"gif_url":
            writer.WriteValue(this.gif_url);
            writer.WriteSpan(StringPool.Slice(21568, 16)); // ,"gif_duration":
            writer.WriteValue(this.gif_duration);
            writer.WriteSpan(StringPool.Slice(21584, 13)); // ,"gif_width":
            writer.WriteValue(this.gif_width);
            writer.WriteSpan(StringPool.Slice(21600, 14)); // ,"gif_height":
            writer.WriteValue(this.gif_height);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.input_message_content != null)
            {
                writer.WriteSpan(StringPool.Slice(21616, 25)); // ,"input_message_content":
                writer.WriteValue(this.input_message_content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputInlineQueryResultAnimatedMpeg4
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(21648, 46)); // {"@type":"inputInlineQueryResultAnimatedMpeg4"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(21528, 17)); // ,"thumbnail_url":
            writer.WriteValue(this.thumbnail_url);
            writer.WriteSpan(StringPool.Slice(21696, 13)); // ,"mpeg4_url":
            writer.WriteValue(this.mpeg4_url);
            writer.WriteSpan(StringPool.Slice(21712, 18)); // ,"mpeg4_duration":
            writer.WriteValue(this.mpeg4_duration);
            writer.WriteSpan(StringPool.Slice(21736, 15)); // ,"mpeg4_width":
            writer.WriteValue(this.mpeg4_width);
            writer.WriteSpan(StringPool.Slice(21752, 16)); // ,"mpeg4_height":
            writer.WriteValue(this.mpeg4_height);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.input_message_content != null)
            {
                writer.WriteSpan(StringPool.Slice(21616, 25)); // ,"input_message_content":
                writer.WriteValue(this.input_message_content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputInlineQueryResultArticle
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(21768, 40)); // {"@type":"inputInlineQueryResultArticle"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(8432, 7)); // ,"url":
            writer.WriteValue(this.url);
            writer.WriteSpan(StringPool.Slice(21808, 12)); // ,"hide_url":
            writer.WriteValue(this.hide_url);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(3408, 15)); // ,"description":
            writer.WriteValue(this.description);
            writer.WriteSpan(StringPool.Slice(21528, 17)); // ,"thumbnail_url":
            writer.WriteValue(this.thumbnail_url);
            writer.WriteSpan(StringPool.Slice(21824, 19)); // ,"thumbnail_width":
            writer.WriteValue(this.thumbnail_width);
            writer.WriteSpan(StringPool.Slice(21848, 20)); // ,"thumbnail_height":
            writer.WriteValue(this.thumbnail_height);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.input_message_content != null)
            {
                writer.WriteSpan(StringPool.Slice(21616, 25)); // ,"input_message_content":
                writer.WriteValue(this.input_message_content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputInlineQueryResultAudio
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(21872, 38)); // {"@type":"inputInlineQueryResultAudio"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(2768, 13)); // ,"performer":
            writer.WriteValue(this.performer);
            writer.WriteSpan(StringPool.Slice(21912, 13)); // ,"audio_url":
            writer.WriteValue(this.audio_url);
            writer.WriteSpan(StringPool.Slice(21928, 18)); // ,"audio_duration":
            writer.WriteValue(this.audio_duration);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.input_message_content != null)
            {
                writer.WriteSpan(StringPool.Slice(21616, 25)); // ,"input_message_content":
                writer.WriteValue(this.input_message_content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputInlineQueryResultContact
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(21952, 40)); // {"@type":"inputInlineQueryResultContact"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            if (this.contact != null)
            {
                writer.WriteSpan(StringPool.Slice(16392, 11)); // ,"contact":
                writer.WriteValue(this.contact);
            }
            writer.WriteSpan(StringPool.Slice(21528, 17)); // ,"thumbnail_url":
            writer.WriteValue(this.thumbnail_url);
            writer.WriteSpan(StringPool.Slice(21824, 19)); // ,"thumbnail_width":
            writer.WriteValue(this.thumbnail_width);
            writer.WriteSpan(StringPool.Slice(21848, 20)); // ,"thumbnail_height":
            writer.WriteValue(this.thumbnail_height);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.input_message_content != null)
            {
                writer.WriteSpan(StringPool.Slice(21616, 25)); // ,"input_message_content":
                writer.WriteValue(this.input_message_content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputInlineQueryResultDocument
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(21992, 41)); // {"@type":"inputInlineQueryResultDocument"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(3408, 15)); // ,"description":
            writer.WriteValue(this.description);
            writer.WriteSpan(StringPool.Slice(22040, 16)); // ,"document_url":
            writer.WriteValue(this.document_url);
            writer.WriteSpan(StringPool.Slice(2688, 13)); // ,"mime_type":
            writer.WriteValue(this.mime_type);
            writer.WriteSpan(StringPool.Slice(21528, 17)); // ,"thumbnail_url":
            writer.WriteValue(this.thumbnail_url);
            writer.WriteSpan(StringPool.Slice(21824, 19)); // ,"thumbnail_width":
            writer.WriteValue(this.thumbnail_width);
            writer.WriteSpan(StringPool.Slice(21848, 20)); // ,"thumbnail_height":
            writer.WriteValue(this.thumbnail_height);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.input_message_content != null)
            {
                writer.WriteSpan(StringPool.Slice(21616, 25)); // ,"input_message_content":
                writer.WriteValue(this.input_message_content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputInlineQueryResultGame
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(22056, 37)); // {"@type":"inputInlineQueryResultGame"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(18672, 19)); // ,"game_short_name":
            writer.WriteValue(this.game_short_name);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputInlineQueryResultLocation
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(22096, 41)); // {"@type":"inputInlineQueryResultLocation"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            if (this.location != null)
            {
                writer.WriteSpan(StringPool.Slice(3328, 12)); // ,"location":
                writer.WriteValue(this.location);
            }
            writer.WriteSpan(StringPool.Slice(16288, 15)); // ,"live_period":
            writer.WriteValue(this.live_period);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(21528, 17)); // ,"thumbnail_url":
            writer.WriteValue(this.thumbnail_url);
            writer.WriteSpan(StringPool.Slice(21824, 19)); // ,"thumbnail_width":
            writer.WriteValue(this.thumbnail_width);
            writer.WriteSpan(StringPool.Slice(21848, 20)); // ,"thumbnail_height":
            writer.WriteValue(this.thumbnail_height);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.input_message_content != null)
            {
                writer.WriteSpan(StringPool.Slice(21616, 25)); // ,"input_message_content":
                writer.WriteValue(this.input_message_content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputInlineQueryResultPhoto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(22144, 38)); // {"@type":"inputInlineQueryResultPhoto"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(3408, 15)); // ,"description":
            writer.WriteValue(this.description);
            writer.WriteSpan(StringPool.Slice(21528, 17)); // ,"thumbnail_url":
            writer.WriteValue(this.thumbnail_url);
            writer.WriteSpan(StringPool.Slice(18728, 13)); // ,"photo_url":
            writer.WriteValue(this.photo_url);
            writer.WriteSpan(StringPool.Slice(18760, 15)); // ,"photo_width":
            writer.WriteValue(this.photo_width);
            writer.WriteSpan(StringPool.Slice(18776, 16)); // ,"photo_height":
            writer.WriteValue(this.photo_height);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.input_message_content != null)
            {
                writer.WriteSpan(StringPool.Slice(21616, 25)); // ,"input_message_content":
                writer.WriteValue(this.input_message_content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputInlineQueryResultSticker
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(22184, 40)); // {"@type":"inputInlineQueryResultSticker"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(21528, 17)); // ,"thumbnail_url":
            writer.WriteValue(this.thumbnail_url);
            writer.WriteSpan(StringPool.Slice(22224, 15)); // ,"sticker_url":
            writer.WriteValue(this.sticker_url);
            writer.WriteSpan(StringPool.Slice(22240, 17)); // ,"sticker_width":
            writer.WriteValue(this.sticker_width);
            writer.WriteSpan(StringPool.Slice(22264, 18)); // ,"sticker_height":
            writer.WriteValue(this.sticker_height);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.input_message_content != null)
            {
                writer.WriteSpan(StringPool.Slice(21616, 25)); // ,"input_message_content":
                writer.WriteValue(this.input_message_content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputInlineQueryResultVenue
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(22288, 38)); // {"@type":"inputInlineQueryResultVenue"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            if (this.venue != null)
            {
                writer.WriteSpan(StringPool.Slice(16344, 9)); // ,"venue":
                writer.WriteValue(this.venue);
            }
            writer.WriteSpan(StringPool.Slice(21528, 17)); // ,"thumbnail_url":
            writer.WriteValue(this.thumbnail_url);
            writer.WriteSpan(StringPool.Slice(21824, 19)); // ,"thumbnail_width":
            writer.WriteValue(this.thumbnail_width);
            writer.WriteSpan(StringPool.Slice(21848, 20)); // ,"thumbnail_height":
            writer.WriteValue(this.thumbnail_height);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.input_message_content != null)
            {
                writer.WriteSpan(StringPool.Slice(21616, 25)); // ,"input_message_content":
                writer.WriteValue(this.input_message_content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputInlineQueryResultVideo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(22328, 38)); // {"@type":"inputInlineQueryResultVideo"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(3408, 15)); // ,"description":
            writer.WriteValue(this.description);
            writer.WriteSpan(StringPool.Slice(21528, 17)); // ,"thumbnail_url":
            writer.WriteValue(this.thumbnail_url);
            writer.WriteSpan(StringPool.Slice(22368, 13)); // ,"video_url":
            writer.WriteValue(this.video_url);
            writer.WriteSpan(StringPool.Slice(2688, 13)); // ,"mime_type":
            writer.WriteValue(this.mime_type);
            writer.WriteSpan(StringPool.Slice(22384, 15)); // ,"video_width":
            writer.WriteValue(this.video_width);
            writer.WriteSpan(StringPool.Slice(22400, 16)); // ,"video_height":
            writer.WriteValue(this.video_height);
            writer.WriteSpan(StringPool.Slice(22416, 18)); // ,"video_duration":
            writer.WriteValue(this.video_duration);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.input_message_content != null)
            {
                writer.WriteSpan(StringPool.Slice(21616, 25)); // ,"input_message_content":
                writer.WriteValue(this.input_message_content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputInlineQueryResultVoiceNote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(22440, 42)); // {"@type":"inputInlineQueryResultVoiceNote"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(22488, 18)); // ,"voice_note_url":
            writer.WriteValue(this.voice_note_url);
            writer.WriteSpan(StringPool.Slice(22512, 23)); // ,"voice_note_duration":
            writer.WriteValue(this.voice_note_duration);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.input_message_content != null)
            {
                writer.WriteSpan(StringPool.Slice(21616, 25)); // ,"input_message_content":
                writer.WriteValue(this.input_message_content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InlineQueryResultArticle
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(22536, 35)); // {"@type":"inlineQueryResultArticle"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(8432, 7)); // ,"url":
            writer.WriteValue(this.url);
            writer.WriteSpan(StringPool.Slice(21808, 12)); // ,"hide_url":
            writer.WriteValue(this.hide_url);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(3408, 15)); // ,"description":
            writer.WriteValue(this.description);
            if (this.thumbnail != null)
            {
                writer.WriteSpan(StringPool.Slice(2704, 13)); // ,"thumbnail":
                writer.WriteValue(this.thumbnail);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InlineQueryResultContact
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(22576, 35)); // {"@type":"inlineQueryResultContact"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            if (this.contact != null)
            {
                writer.WriteSpan(StringPool.Slice(16392, 11)); // ,"contact":
                writer.WriteValue(this.contact);
            }
            if (this.thumbnail != null)
            {
                writer.WriteSpan(StringPool.Slice(2704, 13)); // ,"thumbnail":
                writer.WriteValue(this.thumbnail);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InlineQueryResultLocation
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(22616, 36)); // {"@type":"inlineQueryResultLocation"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            if (this.location != null)
            {
                writer.WriteSpan(StringPool.Slice(3328, 12)); // ,"location":
                writer.WriteValue(this.location);
            }
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            if (this.thumbnail != null)
            {
                writer.WriteSpan(StringPool.Slice(2704, 13)); // ,"thumbnail":
                writer.WriteValue(this.thumbnail);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InlineQueryResultVenue
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(22656, 33)); // {"@type":"inlineQueryResultVenue"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            if (this.venue != null)
            {
                writer.WriteSpan(StringPool.Slice(16344, 9)); // ,"venue":
                writer.WriteValue(this.venue);
            }
            if (this.thumbnail != null)
            {
                writer.WriteSpan(StringPool.Slice(2704, 13)); // ,"thumbnail":
                writer.WriteValue(this.thumbnail);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InlineQueryResultGame
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(22696, 32)); // {"@type":"inlineQueryResultGame"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            if (this.game != null)
            {
                writer.WriteSpan(StringPool.Slice(16432, 8)); // ,"game":
                writer.WriteValue(this.game);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InlineQueryResultAnimation
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(22728, 37)); // {"@type":"inlineQueryResultAnimation"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            if (this.animation != null)
            {
                writer.WriteSpan(StringPool.Slice(2720, 13)); // ,"animation":
                writer.WriteValue(this.animation);
            }
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InlineQueryResultAudio
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(22768, 33)); // {"@type":"inlineQueryResultAudio"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            if (this.audio != null)
            {
                writer.WriteSpan(StringPool.Slice(2816, 9)); // ,"audio":
                writer.WriteValue(this.audio);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InlineQueryResultDocument
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(22808, 36)); // {"@type":"inlineQueryResultDocument"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            if (this.document != null)
            {
                writer.WriteSpan(StringPool.Slice(2856, 12)); // ,"document":
                writer.WriteValue(this.document);
            }
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(3408, 15)); // ,"description":
            writer.WriteValue(this.description);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InlineQueryResultPhoto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(22848, 33)); // {"@type":"inlineQueryResultPhoto"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            if (this.photo != null)
            {
                writer.WriteSpan(StringPool.Slice(2384, 9)); // ,"photo":
                writer.WriteValue(this.photo);
            }
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(3408, 15)); // ,"description":
            writer.WriteValue(this.description);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InlineQueryResultSticker
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(22888, 35)); // {"@type":"inlineQueryResultSticker"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            if (this.sticker != null)
            {
                writer.WriteSpan(StringPool.Slice(3016, 11)); // ,"sticker":
                writer.WriteValue(this.sticker);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InlineQueryResultVideo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(22928, 33)); // {"@type":"inlineQueryResultVideo"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            if (this.video != null)
            {
                writer.WriteSpan(StringPool.Slice(3072, 9)); // ,"video":
                writer.WriteValue(this.video);
            }
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(3408, 15)); // ,"description":
            writer.WriteValue(this.description);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InlineQueryResultVoiceNote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(22968, 37)); // {"@type":"inlineQueryResultVoiceNote"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            if (this.voice_note != null)
            {
                writer.WriteSpan(StringPool.Slice(10432, 14)); // ,"voice_note":
                writer.WriteValue(this.voice_note);
            }
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InlineQueryResults
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(23008, 29)); // {"@type":"inlineQueryResults"
            writer.WriteSpan(StringPool.Slice(23040, 19)); // ,"inline_query_id":
            writer.WriteInt64String(this.inline_query_id);
            writer.WriteSpan(StringPool.Slice(23064, 15)); // ,"next_offset":
            writer.WriteValue(this.next_offset);
            if (this.results != null)
            {
                writer.WriteSpan(StringPool.Slice(23080, 11)); // ,"results":
                writer.WriteArray(this.results);
            }
            writer.WriteSpan(StringPool.Slice(23096, 18)); // ,"switch_pm_text":
            writer.WriteValue(this.switch_pm_text);
            writer.WriteSpan(StringPool.Slice(23120, 23)); // ,"switch_pm_parameter":
            writer.WriteValue(this.switch_pm_parameter);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CallbackQueryPayloadData
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(23144, 35)); // {"@type":"callbackQueryPayloadData"
            if (this.data != null)
            {
                writer.WriteSpan(StringPool.Slice(8488, 8)); // ,"data":
                writer.WriteBytesValue(this.data);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CallbackQueryPayloadGame
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(23184, 35)); // {"@type":"callbackQueryPayloadGame"
            writer.WriteSpan(StringPool.Slice(18672, 19)); // ,"game_short_name":
            writer.WriteValue(this.game_short_name);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CallbackQueryAnswer
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(23224, 30)); // {"@type":"callbackQueryAnswer"
            writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
            writer.WriteValue(this.text);
            writer.WriteSpan(StringPool.Slice(23256, 14)); // ,"show_alert":
            writer.WriteValue(this.show_alert);
            writer.WriteSpan(StringPool.Slice(8432, 7)); // ,"url":
            writer.WriteValue(this.url);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CustomRequestResult
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(23272, 30)); // {"@type":"customRequestResult"
            writer.WriteSpan(StringPool.Slice(23304, 10)); // ,"result":
            writer.WriteValue(this.result);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GameHighScore
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(23320, 24)); // {"@type":"gameHighScore"
            writer.WriteSpan(StringPool.Slice(23344, 12)); // ,"position":
            writer.WriteValue(this.position);
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            writer.WriteSpan(StringPool.Slice(17176, 9)); // ,"score":
            writer.WriteValue(this.score);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GameHighScores
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(23360, 25)); // {"@type":"gameHighScores"
            if (this.scores != null)
            {
                writer.WriteSpan(StringPool.Slice(23392, 10)); // ,"scores":
                writer.WriteArray(this.scores);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEventMessageEdited
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(23408, 33)); // {"@type":"chatEventMessageEdited"
            if (this.old_message != null)
            {
                writer.WriteSpan(StringPool.Slice(23448, 15)); // ,"old_message":
                writer.WriteValue(this.old_message);
            }
            if (this.new_message != null)
            {
                writer.WriteSpan(StringPool.Slice(23464, 15)); // ,"new_message":
                writer.WriteValue(this.new_message);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEventMessageDeleted
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(23480, 34)); // {"@type":"chatEventMessageDeleted"
            if (this.message != null)
            {
                writer.WriteSpan(StringPool.Slice(40, 11)); // ,"message":
                writer.WriteValue(this.message);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEventMessagePinned
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(23520, 33)); // {"@type":"chatEventMessagePinned"
            if (this.message != null)
            {
                writer.WriteSpan(StringPool.Slice(40, 11)); // ,"message":
                writer.WriteValue(this.message);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEventMessageUnpinned
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(23560, 35)); // {"@type":"chatEventMessageUnpinned"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEventMemberJoined
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(23600, 32)); // {"@type":"chatEventMemberJoined"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEventMemberLeft
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(23632, 30)); // {"@type":"chatEventMemberLeft"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEventMemberInvited
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(23664, 33)); // {"@type":"chatEventMemberInvited"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            if (this.status != null)
            {
                writer.WriteSpan(StringPool.Slice(3952, 10)); // ,"status":
                writer.WriteValue(this.status);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEventMemberPromoted
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(23704, 34)); // {"@type":"chatEventMemberPromoted"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            if (this.old_status != null)
            {
                writer.WriteSpan(StringPool.Slice(23744, 14)); // ,"old_status":
                writer.WriteValue(this.old_status);
            }
            if (this.new_status != null)
            {
                writer.WriteSpan(StringPool.Slice(23760, 14)); // ,"new_status":
                writer.WriteValue(this.new_status);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEventMemberRestricted
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(23776, 36)); // {"@type":"chatEventMemberRestricted"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            if (this.old_status != null)
            {
                writer.WriteSpan(StringPool.Slice(23744, 14)); // ,"old_status":
                writer.WriteValue(this.old_status);
            }
            if (this.new_status != null)
            {
                writer.WriteSpan(StringPool.Slice(23760, 14)); // ,"new_status":
                writer.WriteValue(this.new_status);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEventTitleChanged
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(23816, 32)); // {"@type":"chatEventTitleChanged"
            writer.WriteSpan(StringPool.Slice(23848, 13)); // ,"old_title":
            writer.WriteValue(this.old_title);
            writer.WriteSpan(StringPool.Slice(23864, 13)); // ,"new_title":
            writer.WriteValue(this.new_title);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEventDescriptionChanged
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(23880, 38)); // {"@type":"chatEventDescriptionChanged"
            writer.WriteSpan(StringPool.Slice(23920, 19)); // ,"old_description":
            writer.WriteValue(this.old_description);
            writer.WriteSpan(StringPool.Slice(23944, 19)); // ,"new_description":
            writer.WriteValue(this.new_description);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEventUsernameChanged
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(23968, 35)); // {"@type":"chatEventUsernameChanged"
            writer.WriteSpan(StringPool.Slice(24008, 16)); // ,"old_username":
            writer.WriteValue(this.old_username);
            writer.WriteSpan(StringPool.Slice(24024, 16)); // ,"new_username":
            writer.WriteValue(this.new_username);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEventPhotoChanged
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(24040, 32)); // {"@type":"chatEventPhotoChanged"
            if (this.old_photo != null)
            {
                writer.WriteSpan(StringPool.Slice(24072, 13)); // ,"old_photo":
                writer.WriteValue(this.old_photo);
            }
            if (this.new_photo != null)
            {
                writer.WriteSpan(StringPool.Slice(24088, 13)); // ,"new_photo":
                writer.WriteValue(this.new_photo);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEventInvitesToggled
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(24104, 34)); // {"@type":"chatEventInvitesToggled"
            writer.WriteSpan(StringPool.Slice(5824, 21)); // ,"anyone_can_invite":
            writer.WriteValue(this.anyone_can_invite);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEventSignMessagesToggled
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(24144, 39)); // {"@type":"chatEventSignMessagesToggled"
            writer.WriteSpan(StringPool.Slice(5848, 17)); // ,"sign_messages":
            writer.WriteValue(this.sign_messages);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEventStickerSetChanged
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(24184, 37)); // {"@type":"chatEventStickerSetChanged"
            writer.WriteSpan(StringPool.Slice(24224, 22)); // ,"old_sticker_set_id":
            writer.WriteInt64String(this.old_sticker_set_id);
            writer.WriteSpan(StringPool.Slice(24248, 22)); // ,"new_sticker_set_id":
            writer.WriteInt64String(this.new_sticker_set_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEventIsAllHistoryAvailableToggled
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(24272, 48)); // {"@type":"chatEventIsAllHistoryAvailableToggled"
            writer.WriteSpan(StringPool.Slice(6056, 28)); // ,"is_all_history_available":
            writer.WriteValue(this.is_all_history_available);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEvent
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(24320, 20)); // {"@type":"chatEvent"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteInt64String(this.id);
            writer.WriteSpan(StringPool.Slice(5816, 8)); // ,"date":
            writer.WriteValue(this.date);
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            if (this.action != null)
            {
                writer.WriteSpan(StringPool.Slice(24344, 10)); // ,"action":
                writer.WriteValue(this.action);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEvents
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(24360, 21)); // {"@type":"chatEvents"
            if (this.events != null)
            {
                writer.WriteSpan(StringPool.Slice(24384, 10)); // ,"events":
                writer.WriteArray(this.events);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatEventLogFilters
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(24400, 30)); // {"@type":"chatEventLogFilters"
            writer.WriteSpan(StringPool.Slice(24432, 17)); // ,"message_edits":
            writer.WriteValue(this.message_edits);
            writer.WriteSpan(StringPool.Slice(24456, 21)); // ,"message_deletions":
            writer.WriteValue(this.message_deletions);
            writer.WriteSpan(StringPool.Slice(24480, 16)); // ,"message_pins":
            writer.WriteValue(this.message_pins);
            writer.WriteSpan(StringPool.Slice(24496, 16)); // ,"member_joins":
            writer.WriteValue(this.member_joins);
            writer.WriteSpan(StringPool.Slice(24512, 17)); // ,"member_leaves":
            writer.WriteValue(this.member_leaves);
            writer.WriteSpan(StringPool.Slice(24536, 18)); // ,"member_invites":
            writer.WriteValue(this.member_invites);
            writer.WriteSpan(StringPool.Slice(24560, 21)); // ,"member_promotions":
            writer.WriteValue(this.member_promotions);
            writer.WriteSpan(StringPool.Slice(24584, 23)); // ,"member_restrictions":
            writer.WriteValue(this.member_restrictions);
            writer.WriteSpan(StringPool.Slice(24608, 16)); // ,"info_changes":
            writer.WriteValue(this.info_changes);
            writer.WriteSpan(StringPool.Slice(24624, 19)); // ,"setting_changes":
            writer.WriteValue(this.setting_changes);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class LanguagePackStringValueOrdinary
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(24648, 42)); // {"@type":"languagePackStringValueOrdinary"
            writer.WriteSpan(StringPool.Slice(15256, 9)); // ,"value":
            writer.WriteValue(this.value);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class LanguagePackStringValuePluralized
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(24696, 44)); // {"@type":"languagePackStringValuePluralized"
            writer.WriteSpan(StringPool.Slice(24744, 14)); // ,"zero_value":
            writer.WriteValue(this.zero_value);
            writer.WriteSpan(StringPool.Slice(24760, 13)); // ,"one_value":
            writer.WriteValue(this.one_value);
            writer.WriteSpan(StringPool.Slice(24776, 13)); // ,"two_value":
            writer.WriteValue(this.two_value);
            writer.WriteSpan(StringPool.Slice(24792, 13)); // ,"few_value":
            writer.WriteValue(this.few_value);
            writer.WriteSpan(StringPool.Slice(24808, 14)); // ,"many_value":
            writer.WriteValue(this.many_value);
            writer.WriteSpan(StringPool.Slice(24824, 15)); // ,"other_value":
            writer.WriteValue(this.other_value);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class LanguagePackStringValueDeleted
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(24840, 41)); // {"@type":"languagePackStringValueDeleted"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class LanguagePackString
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(24888, 29)); // {"@type":"languagePackString"
            writer.WriteSpan(StringPool.Slice(24920, 7)); // ,"key":
            writer.WriteValue(this.key);
            if (this.value != null)
            {
                writer.WriteSpan(StringPool.Slice(15256, 9)); // ,"value":
                writer.WriteValue(this.value);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class LanguagePackStrings
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(24928, 30)); // {"@type":"languagePackStrings"
            if (this.strings != null)
            {
                writer.WriteSpan(StringPool.Slice(24960, 11)); // ,"strings":
                writer.WriteArray(this.strings);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class LanguagePackInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(24976, 27)); // {"@type":"languagePackInfo"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(9624, 8)); // ,"name":
            writer.WriteValue(this.name);
            writer.WriteSpan(StringPool.Slice(25008, 15)); // ,"native_name":
            writer.WriteValue(this.native_name);
            writer.WriteSpan(StringPool.Slice(25024, 22)); // ,"local_string_count":
            writer.WriteValue(this.local_string_count);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class LocalizationTargetInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(25048, 33)); // {"@type":"localizationTargetInfo"
            if (this.language_packs != null)
            {
                writer.WriteSpan(StringPool.Slice(25088, 18)); // ,"language_packs":
                writer.WriteArray(this.language_packs);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeviceTokenGoogleCloudMessaging
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(25112, 42)); // {"@type":"deviceTokenGoogleCloudMessaging"
            writer.WriteSpan(StringPool.Slice(25160, 9)); // ,"token":
            writer.WriteValue(this.token);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeviceTokenApplePush
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(25176, 31)); // {"@type":"deviceTokenApplePush"
            writer.WriteSpan(StringPool.Slice(25208, 16)); // ,"device_token":
            writer.WriteValue(this.device_token);
            writer.WriteSpan(StringPool.Slice(25224, 18)); // ,"is_app_sandbox":
            writer.WriteValue(this.is_app_sandbox);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeviceTokenApplePushVoIP
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(25248, 35)); // {"@type":"deviceTokenApplePushVoIP"
            writer.WriteSpan(StringPool.Slice(25208, 16)); // ,"device_token":
            writer.WriteValue(this.device_token);
            writer.WriteSpan(StringPool.Slice(25224, 18)); // ,"is_app_sandbox":
            writer.WriteValue(this.is_app_sandbox);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeviceTokenWindowsPush
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(25288, 33)); // {"@type":"deviceTokenWindowsPush"
            writer.WriteSpan(StringPool.Slice(25328, 16)); // ,"access_token":
            writer.WriteValue(this.access_token);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeviceTokenMicrosoftPush
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(25344, 35)); // {"@type":"deviceTokenMicrosoftPush"
            writer.WriteSpan(StringPool.Slice(25384, 15)); // ,"channel_uri":
            writer.WriteValue(this.channel_uri);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeviceTokenMicrosoftPushVoIP
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(25400, 39)); // {"@type":"deviceTokenMicrosoftPushVoIP"
            writer.WriteSpan(StringPool.Slice(25384, 15)); // ,"channel_uri":
            writer.WriteValue(this.channel_uri);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeviceTokenWebPush
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(25440, 29)); // {"@type":"deviceTokenWebPush"
            writer.WriteSpan(StringPool.Slice(25472, 12)); // ,"endpoint":
            writer.WriteValue(this.endpoint);
            writer.WriteSpan(StringPool.Slice(25488, 20)); // ,"p256dh_base64url":
            writer.WriteValue(this.p256dh_base64url);
            writer.WriteSpan(StringPool.Slice(25512, 18)); // ,"auth_base64url":
            writer.WriteValue(this.auth_base64url);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeviceTokenSimplePush
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(25536, 32)); // {"@type":"deviceTokenSimplePush"
            writer.WriteSpan(StringPool.Slice(25472, 12)); // ,"endpoint":
            writer.WriteValue(this.endpoint);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeviceTokenUbuntuPush
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(25568, 32)); // {"@type":"deviceTokenUbuntuPush"
            writer.WriteSpan(StringPool.Slice(25160, 9)); // ,"token":
            writer.WriteValue(this.token);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeviceTokenBlackBerryPush
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(25600, 36)); // {"@type":"deviceTokenBlackBerryPush"
            writer.WriteSpan(StringPool.Slice(25160, 9)); // ,"token":
            writer.WriteValue(this.token);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeviceTokenTizenPush
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(25640, 31)); // {"@type":"deviceTokenTizenPush"
            writer.WriteSpan(StringPool.Slice(25672, 10)); // ,"reg_id":
            writer.WriteValue(this.reg_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Wallpaper
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(25688, 20)); // {"@type":"wallpaper"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            if (this.sizes != null)
            {
                writer.WriteSpan(StringPool.Slice(2904, 9)); // ,"sizes":
                writer.WriteArray(this.sizes);
            }
            writer.WriteSpan(StringPool.Slice(25712, 9)); // ,"color":
            writer.WriteValue(this.color);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Wallpapers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(25728, 21)); // {"@type":"wallpapers"
            if (this.wallpapers != null)
            {
                writer.WriteSpan(StringPool.Slice(25752, 14)); // ,"wallpapers":
                writer.WriteArray(this.wallpapers);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Hashtags
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(25768, 19)); // {"@type":"hashtags"
            if (this.hashtags != null)
            {
                writer.WriteSpan(StringPool.Slice(25792, 12)); // ,"hashtags":
                writer.WriteArray(this.hashtags);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CheckChatUsernameResultOk
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(25808, 36)); // {"@type":"checkChatUsernameResultOk"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CheckChatUsernameResultUsernameInvalid
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(25848, 49)); // {"@type":"checkChatUsernameResultUsernameInvalid"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CheckChatUsernameResultUsernameOccupied
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(25904, 50)); // {"@type":"checkChatUsernameResultUsernameOccupied"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CheckChatUsernameResultPublicChatsTooMuch
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(25960, 52)); // {"@type":"checkChatUsernameResultPublicChatsTooMuch"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CheckChatUsernameResultPublicGroupsUnavailable
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26016, 57)); // {"@type":"checkChatUsernameResultPublicGroupsUnavailable"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class OptionValueBoolean
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26080, 29)); // {"@type":"optionValueBoolean"
            writer.WriteSpan(StringPool.Slice(15256, 9)); // ,"value":
            writer.WriteValue(this.value);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class OptionValueEmpty
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26112, 27)); // {"@type":"optionValueEmpty"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class OptionValueInteger
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26144, 29)); // {"@type":"optionValueInteger"
            writer.WriteSpan(StringPool.Slice(15256, 9)); // ,"value":
            writer.WriteValue(this.value);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class OptionValueString
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26176, 28)); // {"@type":"optionValueString"
            writer.WriteSpan(StringPool.Slice(15256, 9)); // ,"value":
            writer.WriteValue(this.value);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserPrivacySettingRuleAllowAll
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26208, 41)); // {"@type":"userPrivacySettingRuleAllowAll"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserPrivacySettingRuleAllowContacts
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26256, 46)); // {"@type":"userPrivacySettingRuleAllowContacts"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserPrivacySettingRuleAllowUsers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26304, 43)); // {"@type":"userPrivacySettingRuleAllowUsers"
            if (this.user_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(4360, 12)); // ,"user_ids":
                writer.WriteArray(this.user_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserPrivacySettingRuleRestrictAll
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26352, 44)); // {"@type":"userPrivacySettingRuleRestrictAll"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserPrivacySettingRuleRestrictContacts
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26400, 49)); // {"@type":"userPrivacySettingRuleRestrictContacts"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserPrivacySettingRuleRestrictUsers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26456, 46)); // {"@type":"userPrivacySettingRuleRestrictUsers"
            if (this.user_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(4360, 12)); // ,"user_ids":
                writer.WriteArray(this.user_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserPrivacySettingRules
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26504, 34)); // {"@type":"userPrivacySettingRules"
            if (this.rules != null)
            {
                writer.WriteSpan(StringPool.Slice(26544, 9)); // ,"rules":
                writer.WriteArray(this.rules);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserPrivacySettingShowStatus
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26560, 39)); // {"@type":"userPrivacySettingShowStatus"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserPrivacySettingAllowChatInvites
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26600, 45)); // {"@type":"userPrivacySettingAllowChatInvites"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UserPrivacySettingAllowCalls
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26648, 39)); // {"@type":"userPrivacySettingAllowCalls"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AccountTtl
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26688, 21)); // {"@type":"accountTtl"
            writer.WriteSpan(StringPool.Slice(26712, 8)); // ,"days":
            writer.WriteValue(this.days);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Session
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26720, 18)); // {"@type":"session"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteInt64String(this.id);
            writer.WriteSpan(StringPool.Slice(26744, 14)); // ,"is_current":
            writer.WriteValue(this.is_current);
            writer.WriteSpan(StringPool.Slice(272, 10)); // ,"api_id":
            writer.WriteValue(this.api_id);
            writer.WriteSpan(StringPool.Slice(26760, 20)); // ,"application_name":
            writer.WriteValue(this.application_name);
            writer.WriteSpan(StringPool.Slice(368, 23)); // ,"application_version":
            writer.WriteValue(this.application_version);
            writer.WriteSpan(StringPool.Slice(26784, 27)); // ,"is_official_application":
            writer.WriteValue(this.is_official_application);
            writer.WriteSpan(StringPool.Slice(328, 16)); // ,"device_model":
            writer.WriteValue(this.device_model);
            writer.WriteSpan(StringPool.Slice(26816, 12)); // ,"platform":
            writer.WriteValue(this.platform);
            writer.WriteSpan(StringPool.Slice(344, 18)); // ,"system_version":
            writer.WriteValue(this.system_version);
            writer.WriteSpan(StringPool.Slice(26832, 15)); // ,"log_in_date":
            writer.WriteValue(this.log_in_date);
            writer.WriteSpan(StringPool.Slice(26848, 20)); // ,"last_active_date":
            writer.WriteValue(this.last_active_date);
            writer.WriteSpan(StringPool.Slice(20920, 6)); // ,"ip":
            writer.WriteValue(this.ip);
            writer.WriteSpan(StringPool.Slice(26872, 11)); // ,"country":
            writer.WriteValue(this.country);
            writer.WriteSpan(StringPool.Slice(26888, 10)); // ,"region":
            writer.WriteValue(this.region);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Sessions
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26904, 19)); // {"@type":"sessions"
            if (this.sessions != null)
            {
                writer.WriteSpan(StringPool.Slice(26928, 12)); // ,"sessions":
                writer.WriteArray(this.sessions);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ConnectedWebsite
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26944, 27)); // {"@type":"connectedWebsite"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteInt64String(this.id);
            writer.WriteSpan(StringPool.Slice(17488, 15)); // ,"domain_name":
            writer.WriteValue(this.domain_name);
            writer.WriteSpan(StringPool.Slice(18656, 15)); // ,"bot_user_id":
            writer.WriteValue(this.bot_user_id);
            writer.WriteSpan(StringPool.Slice(26976, 11)); // ,"browser":
            writer.WriteValue(this.browser);
            writer.WriteSpan(StringPool.Slice(26816, 12)); // ,"platform":
            writer.WriteValue(this.platform);
            writer.WriteSpan(StringPool.Slice(26832, 15)); // ,"log_in_date":
            writer.WriteValue(this.log_in_date);
            writer.WriteSpan(StringPool.Slice(26848, 20)); // ,"last_active_date":
            writer.WriteValue(this.last_active_date);
            writer.WriteSpan(StringPool.Slice(20920, 6)); // ,"ip":
            writer.WriteValue(this.ip);
            writer.WriteSpan(StringPool.Slice(3328, 12)); // ,"location":
            writer.WriteValue(this.location);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ConnectedWebsites
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(26992, 28)); // {"@type":"connectedWebsites"
            if (this.websites != null)
            {
                writer.WriteSpan(StringPool.Slice(27024, 12)); // ,"websites":
                writer.WriteArray(this.websites);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatReportSpamState
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27040, 30)); // {"@type":"chatReportSpamState"
            writer.WriteSpan(StringPool.Slice(27072, 19)); // ,"can_report_spam":
            writer.WriteValue(this.can_report_spam);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatReportReasonSpam
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27096, 31)); // {"@type":"chatReportReasonSpam"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatReportReasonViolence
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27128, 35)); // {"@type":"chatReportReasonViolence"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatReportReasonPornography
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27168, 38)); // {"@type":"chatReportReasonPornography"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatReportReasonCopyright
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27208, 36)); // {"@type":"chatReportReasonCopyright"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChatReportReasonCustom
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27248, 33)); // {"@type":"chatReportReasonCustom"
            writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
            writer.WriteValue(this.text);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PublicMessageLink
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27288, 28)); // {"@type":"publicMessageLink"
            writer.WriteSpan(StringPool.Slice(27320, 8)); // ,"link":
            writer.WriteValue(this.link);
            writer.WriteSpan(StringPool.Slice(10016, 8)); // ,"html":
            writer.WriteValue(this.html);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class FileTypeNone
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27328, 23)); // {"@type":"fileTypeNone"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class FileTypeAnimation
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27352, 28)); // {"@type":"fileTypeAnimation"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class FileTypeAudio
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27384, 24)); // {"@type":"fileTypeAudio"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class FileTypeDocument
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27408, 27)); // {"@type":"fileTypeDocument"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class FileTypePhoto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27440, 24)); // {"@type":"fileTypePhoto"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class FileTypeProfilePhoto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27464, 31)); // {"@type":"fileTypeProfilePhoto"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class FileTypeSecret
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27496, 25)); // {"@type":"fileTypeSecret"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class FileTypeSecretThumbnail
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27528, 34)); // {"@type":"fileTypeSecretThumbnail"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class FileTypeSecure
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27568, 25)); // {"@type":"fileTypeSecure"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class FileTypeSticker
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27600, 26)); // {"@type":"fileTypeSticker"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class FileTypeThumbnail
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27632, 28)); // {"@type":"fileTypeThumbnail"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class FileTypeUnknown
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27664, 26)); // {"@type":"fileTypeUnknown"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class FileTypeVideo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27696, 24)); // {"@type":"fileTypeVideo"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class FileTypeVideoNote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27720, 28)); // {"@type":"fileTypeVideoNote"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class FileTypeVoiceNote
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27752, 28)); // {"@type":"fileTypeVoiceNote"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class FileTypeWallpaper
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27784, 28)); // {"@type":"fileTypeWallpaper"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class StorageStatisticsByFileType
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27816, 38)); // {"@type":"storageStatisticsByFileType"
            if (this.file_type != null)
            {
                writer.WriteSpan(StringPool.Slice(27856, 13)); // ,"file_type":
                writer.WriteValue(this.file_type);
            }
            writer.WriteSpan(StringPool.Slice(2136, 8)); // ,"size":
            writer.WriteValue(this.size);
            writer.WriteSpan(StringPool.Slice(27872, 9)); // ,"count":
            writer.WriteValue(this.count);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class StorageStatisticsByChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27888, 34)); // {"@type":"storageStatisticsByChat"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(2136, 8)); // ,"size":
            writer.WriteValue(this.size);
            writer.WriteSpan(StringPool.Slice(27872, 9)); // ,"count":
            writer.WriteValue(this.count);
            if (this.by_file_type != null)
            {
                writer.WriteSpan(StringPool.Slice(27928, 16)); // ,"by_file_type":
                writer.WriteArray(this.by_file_type);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class StorageStatistics
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27944, 28)); // {"@type":"storageStatistics"
            writer.WriteSpan(StringPool.Slice(2136, 8)); // ,"size":
            writer.WriteValue(this.size);
            writer.WriteSpan(StringPool.Slice(27872, 9)); // ,"count":
            writer.WriteValue(this.count);
            if (this.by_chat != null)
            {
                writer.WriteSpan(StringPool.Slice(27976, 11)); // ,"by_chat":
                writer.WriteArray(this.by_chat);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class StorageStatisticsFast
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(27992, 32)); // {"@type":"storageStatisticsFast"
            writer.WriteSpan(StringPool.Slice(28024, 14)); // ,"files_size":
            writer.WriteValue(this.files_size);
            writer.WriteSpan(StringPool.Slice(28040, 14)); // ,"file_count":
            writer.WriteValue(this.file_count);
            writer.WriteSpan(StringPool.Slice(28056, 17)); // ,"database_size":
            writer.WriteValue(this.database_size);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class NetworkTypeNone
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28080, 26)); // {"@type":"networkTypeNone"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class NetworkTypeMobile
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28112, 28)); // {"@type":"networkTypeMobile"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class NetworkTypeMobileRoaming
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28144, 35)); // {"@type":"networkTypeMobileRoaming"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class NetworkTypeWiFi
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28184, 26)); // {"@type":"networkTypeWiFi"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class NetworkTypeOther
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28216, 27)); // {"@type":"networkTypeOther"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class NetworkStatisticsEntryFile
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28248, 37)); // {"@type":"networkStatisticsEntryFile"
            if (this.file_type != null)
            {
                writer.WriteSpan(StringPool.Slice(27856, 13)); // ,"file_type":
                writer.WriteValue(this.file_type);
            }
            if (this.network_type != null)
            {
                writer.WriteSpan(StringPool.Slice(28288, 16)); // ,"network_type":
                writer.WriteValue(this.network_type);
            }
            writer.WriteSpan(StringPool.Slice(28304, 14)); // ,"sent_bytes":
            writer.WriteValue(this.sent_bytes);
            writer.WriteSpan(StringPool.Slice(28320, 18)); // ,"received_bytes":
            writer.WriteValue(this.received_bytes);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class NetworkStatisticsEntryCall
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28344, 37)); // {"@type":"networkStatisticsEntryCall"
            if (this.network_type != null)
            {
                writer.WriteSpan(StringPool.Slice(28288, 16)); // ,"network_type":
                writer.WriteValue(this.network_type);
            }
            writer.WriteSpan(StringPool.Slice(28304, 14)); // ,"sent_bytes":
            writer.WriteValue(this.sent_bytes);
            writer.WriteSpan(StringPool.Slice(28320, 18)); // ,"received_bytes":
            writer.WriteValue(this.received_bytes);
            writer.WriteSpan(StringPool.Slice(2656, 12)); // ,"duration":
            writer.WriteValue(this.duration);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class NetworkStatistics
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28384, 28)); // {"@type":"networkStatistics"
            writer.WriteSpan(StringPool.Slice(28416, 14)); // ,"since_date":
            writer.WriteValue(this.since_date);
            if (this.entries != null)
            {
                writer.WriteSpan(StringPool.Slice(28432, 11)); // ,"entries":
                writer.WriteArray(this.entries);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ConnectionStateWaitingForNetwork
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28448, 43)); // {"@type":"connectionStateWaitingForNetwork"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ConnectionStateConnectingToProxy
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28496, 43)); // {"@type":"connectionStateConnectingToProxy"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ConnectionStateConnecting
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28544, 36)); // {"@type":"connectionStateConnecting"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ConnectionStateUpdating
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28584, 34)); // {"@type":"connectionStateUpdating"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ConnectionStateReady
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28624, 31)); // {"@type":"connectionStateReady"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TopChatCategoryUsers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28656, 31)); // {"@type":"topChatCategoryUsers"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TopChatCategoryBots
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28688, 30)); // {"@type":"topChatCategoryBots"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TopChatCategoryGroups
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28720, 32)); // {"@type":"topChatCategoryGroups"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TopChatCategoryChannels
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28752, 34)); // {"@type":"topChatCategoryChannels"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TopChatCategoryInlineBots
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28792, 36)); // {"@type":"topChatCategoryInlineBots"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TopChatCategoryCalls
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28832, 31)); // {"@type":"topChatCategoryCalls"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TMeUrlTypeUser
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28864, 25)); // {"@type":"tMeUrlTypeUser"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TMeUrlTypeSupergroup
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28896, 31)); // {"@type":"tMeUrlTypeSupergroup"
            writer.WriteSpan(StringPool.Slice(7640, 17)); // ,"supergroup_id":
            writer.WriteValue(this.supergroup_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TMeUrlTypeChatInvite
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28928, 31)); // {"@type":"tMeUrlTypeChatInvite"
            if (this.info != null)
            {
                writer.WriteSpan(StringPool.Slice(28960, 8)); // ,"info":
                writer.WriteValue(this.info);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TMeUrlTypeStickerSet
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(28968, 31)); // {"@type":"tMeUrlTypeStickerSet"
            writer.WriteSpan(StringPool.Slice(6088, 18)); // ,"sticker_set_id":
            writer.WriteInt64String(this.sticker_set_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TMeUrl
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29000, 17)); // {"@type":"tMeUrl"
            writer.WriteSpan(StringPool.Slice(8432, 7)); // ,"url":
            writer.WriteValue(this.url);
            if (this.type != null)
            {
                writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
                writer.WriteValue(this.type);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TMeUrls
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29024, 18)); // {"@type":"tMeUrls"
            if (this.urls != null)
            {
                writer.WriteSpan(StringPool.Slice(29048, 8)); // ,"urls":
                writer.WriteArray(this.urls);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Count
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29056, 16)); // {"@type":"count"
            writer.WriteSpan(StringPool.Slice(27872, 9)); // ,"count":
            writer.WriteValue(this.count);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Text
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29072, 15)); // {"@type":"text"
            writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
            writer.WriteValue(this.text);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Seconds
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29088, 18)); // {"@type":"seconds"
            writer.WriteSpan(StringPool.Slice(29112, 11)); // ,"seconds":
            writer.WriteValue(this.seconds);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeepLinkInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29128, 23)); // {"@type":"deepLinkInfo"
            if (this.text != null)
            {
                writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
                writer.WriteValue(this.text);
            }
            writer.WriteSpan(StringPool.Slice(29152, 27)); // ,"need_update_application":
            writer.WriteValue(this.need_update_application);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TextParseModeMarkdown
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29184, 32)); // {"@type":"textParseModeMarkdown"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TextParseModeHTML
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29216, 28)); // {"@type":"textParseModeHTML"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ProxyTypeSocks5
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29248, 26)); // {"@type":"proxyTypeSocks5"
            writer.WriteSpan(StringPool.Slice(3936, 12)); // ,"username":
            writer.WriteValue(this.username);
            writer.WriteSpan(StringPool.Slice(29280, 12)); // ,"password":
            writer.WriteValue(this.password);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ProxyTypeHttp
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29296, 24)); // {"@type":"proxyTypeHttp"
            writer.WriteSpan(StringPool.Slice(3936, 12)); // ,"username":
            writer.WriteValue(this.username);
            writer.WriteSpan(StringPool.Slice(29280, 12)); // ,"password":
            writer.WriteValue(this.password);
            writer.WriteSpan(StringPool.Slice(29320, 13)); // ,"http_only":
            writer.WriteValue(this.http_only);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ProxyTypeMtproto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29336, 27)); // {"@type":"proxyTypeMtproto"
            writer.WriteSpan(StringPool.Slice(15200, 10)); // ,"secret":
            writer.WriteValue(this.secret);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Proxy
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29368, 16)); // {"@type":"proxy"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteValue(this.id);
            writer.WriteSpan(StringPool.Slice(29384, 10)); // ,"server":
            writer.WriteValue(this.server);
            writer.WriteSpan(StringPool.Slice(20936, 8)); // ,"port":
            writer.WriteValue(this.port);
            writer.WriteSpan(StringPool.Slice(29400, 18)); // ,"last_used_date":
            writer.WriteValue(this.last_used_date);
            writer.WriteSpan(StringPool.Slice(29424, 14)); // ,"is_enabled":
            writer.WriteValue(this.is_enabled);
            if (this.type != null)
            {
                writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
                writer.WriteValue(this.type);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Proxies
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29440, 18)); // {"@type":"proxies"
            if (this.proxies != null)
            {
                writer.WriteSpan(StringPool.Slice(29464, 11)); // ,"proxies":
                writer.WriteArray(this.proxies);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class InputSticker
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29480, 23)); // {"@type":"inputSticker"
            if (this.png_sticker != null)
            {
                writer.WriteSpan(StringPool.Slice(29504, 15)); // ,"png_sticker":
                writer.WriteValue(this.png_sticker);
            }
            writer.WriteSpan(StringPool.Slice(20408, 10)); // ,"emojis":
            writer.WriteValue(this.emojis);
            if (this.mask_position != null)
            {
                writer.WriteSpan(StringPool.Slice(2992, 17)); // ,"mask_position":
                writer.WriteValue(this.mask_position);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateAuthorizationState
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29520, 35)); // {"@type":"updateAuthorizationState"
            if (this.authorization_state != null)
            {
                writer.WriteSpan(StringPool.Slice(29560, 23)); // ,"authorization_state":
                writer.WriteValue(this.authorization_state);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateNewMessage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29584, 27)); // {"@type":"updateNewMessage"
            if (this.message != null)
            {
                writer.WriteSpan(StringPool.Slice(40, 11)); // ,"message":
                writer.WriteValue(this.message);
            }
            writer.WriteSpan(StringPool.Slice(29616, 24)); // ,"disable_notification":
            writer.WriteValue(this.disable_notification);
            writer.WriteSpan(StringPool.Slice(29640, 20)); // ,"contains_mention":
            writer.WriteValue(this.contains_mention);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateMessageSendAcknowledged
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29664, 40)); // {"@type":"updateMessageSendAcknowledged"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateMessageSendSucceeded
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29704, 37)); // {"@type":"updateMessageSendSucceeded"
            if (this.message != null)
            {
                writer.WriteSpan(StringPool.Slice(40, 11)); // ,"message":
                writer.WriteValue(this.message);
            }
            writer.WriteSpan(StringPool.Slice(29744, 18)); // ,"old_message_id":
            writer.WriteValue(this.old_message_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateMessageSendFailed
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29768, 34)); // {"@type":"updateMessageSendFailed"
            if (this.message != null)
            {
                writer.WriteSpan(StringPool.Slice(40, 11)); // ,"message":
                writer.WriteValue(this.message);
            }
            writer.WriteSpan(StringPool.Slice(29744, 18)); // ,"old_message_id":
            writer.WriteValue(this.old_message_id);
            writer.WriteSpan(StringPool.Slice(29808, 14)); // ,"error_code":
            writer.WriteValue(this.error_code);
            writer.WriteSpan(StringPool.Slice(29824, 17)); // ,"error_message":
            writer.WriteValue(this.error_message);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateMessageContent
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29848, 31)); // {"@type":"updateMessageContent"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            if (this.new_content != null)
            {
                writer.WriteSpan(StringPool.Slice(29880, 15)); // ,"new_content":
                writer.WriteValue(this.new_content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateMessageEdited
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29896, 30)); // {"@type":"updateMessageEdited"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            writer.WriteSpan(StringPool.Slice(6904, 13)); // ,"edit_date":
            writer.WriteValue(this.edit_date);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateMessageViews
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29928, 29)); // {"@type":"updateMessageViews"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            writer.WriteSpan(StringPool.Slice(7008, 9)); // ,"views":
            writer.WriteValue(this.views);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateMessageContentOpened
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(29960, 37)); // {"@type":"updateMessageContentOpened"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateMessageMentionRead
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30000, 35)); // {"@type":"updateMessageMentionRead"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            writer.WriteSpan(StringPool.Slice(7960, 24)); // ,"unread_mention_count":
            writer.WriteValue(this.unread_mention_count);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateNewChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30040, 24)); // {"@type":"updateNewChat"
            if (this.chat != null)
            {
                writer.WriteSpan(StringPool.Slice(30064, 8)); // ,"chat":
                writer.WriteValue(this.chat);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateChatTitle
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30072, 26)); // {"@type":"updateChatTitle"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateChatPhoto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30104, 26)); // {"@type":"updateChatPhoto"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            if (this.photo != null)
            {
                writer.WriteSpan(StringPool.Slice(2384, 9)); // ,"photo":
                writer.WriteValue(this.photo);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateChatLastMessage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30136, 32)); // {"@type":"updateChatLastMessage"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            if (this.last_message != null)
            {
                writer.WriteSpan(StringPool.Slice(7736, 16)); // ,"last_message":
                writer.WriteValue(this.last_message);
            }
            writer.WriteSpan(StringPool.Slice(7752, 9)); // ,"order":
            writer.WriteInt64String(this.order);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateChatOrder
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30168, 26)); // {"@type":"updateChatOrder"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(7752, 9)); // ,"order":
            writer.WriteInt64String(this.order);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateChatIsPinned
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30200, 29)); // {"@type":"updateChatIsPinned"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(7768, 13)); // ,"is_pinned":
            writer.WriteValue(this.is_pinned);
            writer.WriteSpan(StringPool.Slice(7752, 9)); // ,"order":
            writer.WriteInt64String(this.order);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateChatIsMarkedAsUnread
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30232, 37)); // {"@type":"updateChatIsMarkedAsUnread"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(7784, 23)); // ,"is_marked_as_unread":
            writer.WriteValue(this.is_marked_as_unread);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateChatIsSponsored
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30272, 32)); // {"@type":"updateChatIsSponsored"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(7808, 16)); // ,"is_sponsored":
            writer.WriteValue(this.is_sponsored);
            writer.WriteSpan(StringPool.Slice(7752, 9)); // ,"order":
            writer.WriteInt64String(this.order);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateChatDefaultDisableNotification
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30304, 47)); // {"@type":"updateChatDefaultDisableNotification"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(7848, 32)); // ,"default_disable_notification":
            writer.WriteValue(this.default_disable_notification);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateChatReadInbox
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30352, 30)); // {"@type":"updateChatReadInbox"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(7896, 30)); // ,"last_read_inbox_message_id":
            writer.WriteValue(this.last_read_inbox_message_id);
            writer.WriteSpan(StringPool.Slice(7880, 16)); // ,"unread_count":
            writer.WriteValue(this.unread_count);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateChatReadOutbox
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30384, 31)); // {"@type":"updateChatReadOutbox"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(7928, 31)); // ,"last_read_outbox_message_id":
            writer.WriteValue(this.last_read_outbox_message_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateChatUnreadMentionCount
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30416, 39)); // {"@type":"updateChatUnreadMentionCount"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(7960, 24)); // ,"unread_mention_count":
            writer.WriteValue(this.unread_mention_count);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateChatNotificationSettings
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30456, 41)); // {"@type":"updateChatNotificationSettings"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            if (this.notification_settings != null)
            {
                writer.WriteSpan(StringPool.Slice(7984, 25)); // ,"notification_settings":
                writer.WriteValue(this.notification_settings);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateScopeNotificationSettings
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30504, 42)); // {"@type":"updateScopeNotificationSettings"
            if (this.scope != null)
            {
                writer.WriteSpan(StringPool.Slice(30552, 9)); // ,"scope":
                writer.WriteValue(this.scope);
            }
            if (this.notification_settings != null)
            {
                writer.WriteSpan(StringPool.Slice(7984, 25)); // ,"notification_settings":
                writer.WriteValue(this.notification_settings);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateChatReplyMarkup
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30568, 32)); // {"@type":"updateChatReplyMarkup"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(8016, 27)); // ,"reply_markup_message_id":
            writer.WriteValue(this.reply_markup_message_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateChatDraftMessage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30600, 33)); // {"@type":"updateChatDraftMessage"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            if (this.draft_message != null)
            {
                writer.WriteSpan(StringPool.Slice(8048, 17)); // ,"draft_message":
                writer.WriteValue(this.draft_message);
            }
            writer.WriteSpan(StringPool.Slice(7752, 9)); // ,"order":
            writer.WriteInt64String(this.order);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateDeleteMessages
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30640, 31)); // {"@type":"updateDeleteMessages"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            if (this.message_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(30672, 15)); // ,"message_ids":
                writer.WriteArray(this.message_ids);
            }
            writer.WriteSpan(StringPool.Slice(30688, 16)); // ,"is_permanent":
            writer.WriteValue(this.is_permanent);
            writer.WriteSpan(StringPool.Slice(30704, 14)); // ,"from_cache":
            writer.WriteValue(this.from_cache);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateUserChatAction
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30720, 31)); // {"@type":"updateUserChatAction"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            if (this.action != null)
            {
                writer.WriteSpan(StringPool.Slice(24344, 10)); // ,"action":
                writer.WriteValue(this.action);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateUserStatus
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30752, 27)); // {"@type":"updateUserStatus"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            if (this.status != null)
            {
                writer.WriteSpan(StringPool.Slice(3952, 10)); // ,"status":
                writer.WriteValue(this.status);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateUser
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30784, 21)); // {"@type":"updateUser"
            if (this.user != null)
            {
                writer.WriteSpan(StringPool.Slice(30808, 8)); // ,"user":
                writer.WriteValue(this.user);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateBasicGroup
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30816, 27)); // {"@type":"updateBasicGroup"
            if (this.basic_group != null)
            {
                writer.WriteSpan(StringPool.Slice(30848, 15)); // ,"basic_group":
                writer.WriteValue(this.basic_group);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateSupergroup
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30864, 27)); // {"@type":"updateSupergroup"
            if (this.supergroup != null)
            {
                writer.WriteSpan(StringPool.Slice(30896, 14)); // ,"supergroup":
                writer.WriteValue(this.supergroup);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateSecretChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30912, 27)); // {"@type":"updateSecretChat"
            if (this.secret_chat != null)
            {
                writer.WriteSpan(StringPool.Slice(30944, 15)); // ,"secret_chat":
                writer.WriteValue(this.secret_chat);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateUserFullInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(30960, 29)); // {"@type":"updateUserFullInfo"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            if (this.user_full_info != null)
            {
                writer.WriteSpan(StringPool.Slice(30992, 18)); // ,"user_full_info":
                writer.WriteValue(this.user_full_info);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateBasicGroupFullInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(31016, 35)); // {"@type":"updateBasicGroupFullInfo"
            writer.WriteSpan(StringPool.Slice(7584, 18)); // ,"basic_group_id":
            writer.WriteValue(this.basic_group_id);
            if (this.basic_group_full_info != null)
            {
                writer.WriteSpan(StringPool.Slice(31056, 25)); // ,"basic_group_full_info":
                writer.WriteValue(this.basic_group_full_info);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateSupergroupFullInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(31088, 35)); // {"@type":"updateSupergroupFullInfo"
            writer.WriteSpan(StringPool.Slice(7640, 17)); // ,"supergroup_id":
            writer.WriteValue(this.supergroup_id);
            if (this.supergroup_full_info != null)
            {
                writer.WriteSpan(StringPool.Slice(31128, 24)); // ,"supergroup_full_info":
                writer.WriteValue(this.supergroup_full_info);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateServiceNotification
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(31152, 36)); // {"@type":"updateServiceNotification"
            writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
            writer.WriteValue(this.type);
            if (this.content != null)
            {
                writer.WriteSpan(StringPool.Slice(7048, 11)); // ,"content":
                writer.WriteValue(this.content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateFile
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(31192, 21)); // {"@type":"updateFile"
            if (this.file != null)
            {
                writer.WriteSpan(StringPool.Slice(11776, 8)); // ,"file":
                writer.WriteValue(this.file);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateFileGenerationStart
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(31216, 36)); // {"@type":"updateFileGenerationStart"
            writer.WriteSpan(StringPool.Slice(31256, 17)); // ,"generation_id":
            writer.WriteInt64String(this.generation_id);
            writer.WriteSpan(StringPool.Slice(2320, 17)); // ,"original_path":
            writer.WriteValue(this.original_path);
            writer.WriteSpan(StringPool.Slice(31280, 20)); // ,"destination_path":
            writer.WriteValue(this.destination_path);
            writer.WriteSpan(StringPool.Slice(2344, 14)); // ,"conversion":
            writer.WriteValue(this.conversion);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateFileGenerationStop
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(31304, 35)); // {"@type":"updateFileGenerationStop"
            writer.WriteSpan(StringPool.Slice(31256, 17)); // ,"generation_id":
            writer.WriteInt64String(this.generation_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateCall
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(31344, 21)); // {"@type":"updateCall"
            if (this.call != null)
            {
                writer.WriteSpan(StringPool.Slice(31368, 8)); // ,"call":
                writer.WriteValue(this.call);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateUserPrivacySettingRules
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(31376, 40)); // {"@type":"updateUserPrivacySettingRules"
            if (this.setting != null)
            {
                writer.WriteSpan(StringPool.Slice(31416, 11)); // ,"setting":
                writer.WriteValue(this.setting);
            }
            if (this.rules != null)
            {
                writer.WriteSpan(StringPool.Slice(26544, 9)); // ,"rules":
                writer.WriteValue(this.rules);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateUnreadMessageCount
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(31432, 35)); // {"@type":"updateUnreadMessageCount"
            writer.WriteSpan(StringPool.Slice(7880, 16)); // ,"unread_count":
            writer.WriteValue(this.unread_count);
            writer.WriteSpan(StringPool.Slice(31472, 24)); // ,"unread_unmuted_count":
            writer.WriteValue(this.unread_unmuted_count);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateUnreadChatCount
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(31496, 32)); // {"@type":"updateUnreadChatCount"
            writer.WriteSpan(StringPool.Slice(7880, 16)); // ,"unread_count":
            writer.WriteValue(this.unread_count);
            writer.WriteSpan(StringPool.Slice(31472, 24)); // ,"unread_unmuted_count":
            writer.WriteValue(this.unread_unmuted_count);
            writer.WriteSpan(StringPool.Slice(31528, 26)); // ,"marked_as_unread_count":
            writer.WriteValue(this.marked_as_unread_count);
            writer.WriteSpan(StringPool.Slice(31560, 34)); // ,"marked_as_unread_unmuted_count":
            writer.WriteValue(this.marked_as_unread_unmuted_count);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateOption
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(31600, 23)); // {"@type":"updateOption"
            writer.WriteSpan(StringPool.Slice(9624, 8)); // ,"name":
            writer.WriteValue(this.name);
            if (this.value != null)
            {
                writer.WriteSpan(StringPool.Slice(15256, 9)); // ,"value":
                writer.WriteValue(this.value);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateInstalledStickerSets
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(31624, 37)); // {"@type":"updateInstalledStickerSets"
            writer.WriteSpan(StringPool.Slice(20496, 12)); // ,"is_masks":
            writer.WriteValue(this.is_masks);
            if (this.sticker_set_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(31664, 19)); // ,"sticker_set_ids":
                writer.WriteInt64Array(this.sticker_set_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateTrendingStickerSets
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(31688, 36)); // {"@type":"updateTrendingStickerSets"
            if (this.sticker_sets != null)
            {
                writer.WriteSpan(StringPool.Slice(31728, 16)); // ,"sticker_sets":
                writer.WriteValue(this.sticker_sets);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateRecentStickers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(31744, 31)); // {"@type":"updateRecentStickers"
            writer.WriteSpan(StringPool.Slice(31776, 15)); // ,"is_attached":
            writer.WriteValue(this.is_attached);
            if (this.sticker_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(31792, 15)); // ,"sticker_ids":
                writer.WriteArray(this.sticker_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateFavoriteStickers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(31808, 33)); // {"@type":"updateFavoriteStickers"
            if (this.sticker_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(31792, 15)); // ,"sticker_ids":
                writer.WriteArray(this.sticker_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateSavedAnimations
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(31848, 32)); // {"@type":"updateSavedAnimations"
            if (this.animation_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(31880, 17)); // ,"animation_ids":
                writer.WriteArray(this.animation_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateLanguagePackStrings
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(31904, 36)); // {"@type":"updateLanguagePackStrings"
            writer.WriteSpan(StringPool.Slice(31944, 23)); // ,"localization_target":
            writer.WriteValue(this.localization_target);
            writer.WriteSpan(StringPool.Slice(31968, 20)); // ,"language_pack_id":
            writer.WriteValue(this.language_pack_id);
            if (this.strings != null)
            {
                writer.WriteSpan(StringPool.Slice(24960, 11)); // ,"strings":
                writer.WriteArray(this.strings);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateConnectionState
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(31992, 32)); // {"@type":"updateConnectionState"
            if (this.state != null)
            {
                writer.WriteSpan(StringPool.Slice(6328, 9)); // ,"state":
                writer.WriteValue(this.state);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateTermsOfService
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32024, 31)); // {"@type":"updateTermsOfService"
            writer.WriteSpan(StringPool.Slice(32056, 23)); // ,"terms_of_service_id":
            writer.WriteValue(this.terms_of_service_id);
            if (this.terms_of_service != null)
            {
                writer.WriteSpan(StringPool.Slice(1232, 20)); // ,"terms_of_service":
                writer.WriteValue(this.terms_of_service);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateNewInlineQuery
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32080, 31)); // {"@type":"updateNewInlineQuery"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteInt64String(this.id);
            writer.WriteSpan(StringPool.Slice(6440, 18)); // ,"sender_user_id":
            writer.WriteValue(this.sender_user_id);
            if (this.user_location != null)
            {
                writer.WriteSpan(StringPool.Slice(32112, 17)); // ,"user_location":
                writer.WriteValue(this.user_location);
            }
            writer.WriteSpan(StringPool.Slice(5456, 9)); // ,"query":
            writer.WriteValue(this.query);
            writer.WriteSpan(StringPool.Slice(856, 10)); // ,"offset":
            writer.WriteValue(this.offset);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateNewChosenInlineResult
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32136, 38)); // {"@type":"updateNewChosenInlineResult"
            writer.WriteSpan(StringPool.Slice(6440, 18)); // ,"sender_user_id":
            writer.WriteValue(this.sender_user_id);
            if (this.user_location != null)
            {
                writer.WriteSpan(StringPool.Slice(32112, 17)); // ,"user_location":
                writer.WriteValue(this.user_location);
            }
            writer.WriteSpan(StringPool.Slice(5456, 9)); // ,"query":
            writer.WriteValue(this.query);
            writer.WriteSpan(StringPool.Slice(32176, 13)); // ,"result_id":
            writer.WriteValue(this.result_id);
            writer.WriteSpan(StringPool.Slice(32192, 21)); // ,"inline_message_id":
            writer.WriteValue(this.inline_message_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateNewCallbackQuery
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32216, 33)); // {"@type":"updateNewCallbackQuery"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteInt64String(this.id);
            writer.WriteSpan(StringPool.Slice(6440, 18)); // ,"sender_user_id":
            writer.WriteValue(this.sender_user_id);
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            writer.WriteSpan(StringPool.Slice(32256, 17)); // ,"chat_instance":
            writer.WriteInt64String(this.chat_instance);
            if (this.payload != null)
            {
                writer.WriteSpan(StringPool.Slice(18792, 11)); // ,"payload":
                writer.WriteValue(this.payload);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateNewInlineCallbackQuery
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32280, 39)); // {"@type":"updateNewInlineCallbackQuery"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteInt64String(this.id);
            writer.WriteSpan(StringPool.Slice(6440, 18)); // ,"sender_user_id":
            writer.WriteValue(this.sender_user_id);
            writer.WriteSpan(StringPool.Slice(32192, 21)); // ,"inline_message_id":
            writer.WriteValue(this.inline_message_id);
            writer.WriteSpan(StringPool.Slice(32256, 17)); // ,"chat_instance":
            writer.WriteInt64String(this.chat_instance);
            if (this.payload != null)
            {
                writer.WriteSpan(StringPool.Slice(18792, 11)); // ,"payload":
                writer.WriteValue(this.payload);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateNewShippingQuery
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32320, 33)); // {"@type":"updateNewShippingQuery"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteInt64String(this.id);
            writer.WriteSpan(StringPool.Slice(6440, 18)); // ,"sender_user_id":
            writer.WriteValue(this.sender_user_id);
            writer.WriteSpan(StringPool.Slice(17296, 19)); // ,"invoice_payload":
            writer.WriteValue(this.invoice_payload);
            if (this.shipping_address != null)
            {
                writer.WriteSpan(StringPool.Slice(10920, 20)); // ,"shipping_address":
                writer.WriteValue(this.shipping_address);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateNewPreCheckoutQuery
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32360, 36)); // {"@type":"updateNewPreCheckoutQuery"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteInt64String(this.id);
            writer.WriteSpan(StringPool.Slice(6440, 18)); // ,"sender_user_id":
            writer.WriteValue(this.sender_user_id);
            writer.WriteSpan(StringPool.Slice(10656, 12)); // ,"currency":
            writer.WriteValue(this.currency);
            writer.WriteSpan(StringPool.Slice(16472, 16)); // ,"total_amount":
            writer.WriteValue(this.total_amount);
            if (this.invoice_payload != null)
            {
                writer.WriteSpan(StringPool.Slice(17296, 19)); // ,"invoice_payload":
                writer.WriteBytesValue(this.invoice_payload);
            }
            writer.WriteSpan(StringPool.Slice(17320, 22)); // ,"shipping_option_id":
            writer.WriteValue(this.shipping_option_id);
            if (this.order_info != null)
            {
                writer.WriteSpan(StringPool.Slice(11688, 14)); // ,"order_info":
                writer.WriteValue(this.order_info);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateNewCustomEvent
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32400, 31)); // {"@type":"updateNewCustomEvent"
            writer.WriteSpan(StringPool.Slice(32432, 9)); // ,"event":
            writer.WriteValue(this.@event);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpdateNewCustomQuery
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32448, 31)); // {"@type":"updateNewCustomQuery"
            writer.WriteSpan(StringPool.Slice(2032, 6)); // ,"id":
            writer.WriteInt64String(this.id);
            writer.WriteSpan(StringPool.Slice(8488, 8)); // ,"data":
            writer.WriteValue(this.data);
            writer.WriteSpan(StringPool.Slice(736, 11)); // ,"timeout":
            writer.WriteValue(this.timeout);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TestInt
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32480, 18)); // {"@type":"testInt"
            writer.WriteSpan(StringPool.Slice(15256, 9)); // ,"value":
            writer.WriteValue(this.value);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TestString
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32504, 21)); // {"@type":"testString"
            writer.WriteSpan(StringPool.Slice(15256, 9)); // ,"value":
            writer.WriteValue(this.value);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TestBytes
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32528, 20)); // {"@type":"testBytes"
            if (this.value != null)
            {
                writer.WriteSpan(StringPool.Slice(15256, 9)); // ,"value":
                writer.WriteBytesValue(this.value);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TestVectorInt
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32552, 24)); // {"@type":"testVectorInt"
            if (this.value != null)
            {
                writer.WriteSpan(StringPool.Slice(15256, 9)); // ,"value":
                writer.WriteArray(this.value);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TestVectorIntObject
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32576, 30)); // {"@type":"testVectorIntObject"
            if (this.value != null)
            {
                writer.WriteSpan(StringPool.Slice(15256, 9)); // ,"value":
                writer.WriteArray(this.value);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TestVectorString
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32608, 27)); // {"@type":"testVectorString"
            if (this.value != null)
            {
                writer.WriteSpan(StringPool.Slice(15256, 9)); // ,"value":
                writer.WriteArray(this.value);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TestVectorStringObject
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32640, 33)); // {"@type":"testVectorStringObject"
            if (this.value != null)
            {
                writer.WriteSpan(StringPool.Slice(15256, 9)); // ,"value":
                writer.WriteArray(this.value);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetAuthorizationState
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32680, 32)); // {"@type":"getAuthorizationState"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetTdlibParameters
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32712, 29)); // {"@type":"setTdlibParameters"
            if (this.parameters != null)
            {
                writer.WriteSpan(StringPool.Slice(32744, 14)); // ,"parameters":
                writer.WriteValue(this.parameters);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CheckDatabaseEncryptionKey
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32760, 37)); // {"@type":"checkDatabaseEncryptionKey"
            if (this.encryption_key != null)
            {
                writer.WriteSpan(StringPool.Slice(21168, 18)); // ,"encryption_key":
                writer.WriteBytesValue(this.encryption_key);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetAuthenticationPhoneNumber
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32800, 39)); // {"@type":"setAuthenticationPhoneNumber"
            writer.WriteSpan(StringPool.Slice(696, 16)); // ,"phone_number":
            writer.WriteValue(this.phone_number);
            writer.WriteSpan(StringPool.Slice(32840, 20)); // ,"allow_flash_call":
            writer.WriteValue(this.allow_flash_call);
            writer.WriteSpan(StringPool.Slice(32864, 27)); // ,"is_current_phone_number":
            writer.WriteValue(this.is_current_phone_number);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ResendAuthenticationCode
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32896, 35)); // {"@type":"resendAuthenticationCode"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CheckAuthenticationCode
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32936, 34)); // {"@type":"checkAuthenticationCode"
            writer.WriteSpan(StringPool.Slice(32, 8)); // ,"code":
            writer.WriteValue(this.code);
            writer.WriteSpan(StringPool.Slice(3192, 14)); // ,"first_name":
            writer.WriteValue(this.first_name);
            writer.WriteSpan(StringPool.Slice(3208, 13)); // ,"last_name":
            writer.WriteValue(this.last_name);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CheckAuthenticationPassword
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(32976, 38)); // {"@type":"checkAuthenticationPassword"
            writer.WriteSpan(StringPool.Slice(29280, 12)); // ,"password":
            writer.WriteValue(this.password);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RequestAuthenticationPasswordRecovery
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33016, 48)); // {"@type":"requestAuthenticationPasswordRecovery"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RecoverAuthenticationPassword
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33064, 40)); // {"@type":"recoverAuthenticationPassword"
            writer.WriteSpan(StringPool.Slice(33104, 17)); // ,"recovery_code":
            writer.WriteValue(this.recovery_code);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CheckAuthenticationBotToken
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33128, 38)); // {"@type":"checkAuthenticationBotToken"
            writer.WriteSpan(StringPool.Slice(25160, 9)); // ,"token":
            writer.WriteValue(this.token);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class LogOut
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33168, 17)); // {"@type":"logOut"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Close
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33192, 16)); // {"@type":"close"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class Destroy
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33208, 18)); // {"@type":"destroy"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetDatabaseEncryptionKey
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33232, 35)); // {"@type":"setDatabaseEncryptionKey"
            if (this.new_encryption_key != null)
            {
                writer.WriteSpan(StringPool.Slice(33272, 22)); // ,"new_encryption_key":
                writer.WriteBytesValue(this.new_encryption_key);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetPasswordState
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33296, 27)); // {"@type":"getPasswordState"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetPassword
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33328, 22)); // {"@type":"setPassword"
            writer.WriteSpan(StringPool.Slice(33352, 16)); // ,"old_password":
            writer.WriteValue(this.old_password);
            writer.WriteSpan(StringPool.Slice(33368, 16)); // ,"new_password":
            writer.WriteValue(this.new_password);
            writer.WriteSpan(StringPool.Slice(33384, 12)); // ,"new_hint":
            writer.WriteValue(this.new_hint);
            writer.WriteSpan(StringPool.Slice(33400, 30)); // ,"set_recovery_email_address":
            writer.WriteValue(this.set_recovery_email_address);
            writer.WriteSpan(StringPool.Slice(33432, 30)); // ,"new_recovery_email_address":
            writer.WriteValue(this.new_recovery_email_address);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetRecoveryEmailAddress
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33464, 34)); // {"@type":"getRecoveryEmailAddress"
            writer.WriteSpan(StringPool.Slice(29280, 12)); // ,"password":
            writer.WriteValue(this.password);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetRecoveryEmailAddress
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33504, 34)); // {"@type":"setRecoveryEmailAddress"
            writer.WriteSpan(StringPool.Slice(29280, 12)); // ,"password":
            writer.WriteValue(this.password);
            writer.WriteSpan(StringPool.Slice(33432, 30)); // ,"new_recovery_email_address":
            writer.WriteValue(this.new_recovery_email_address);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RequestPasswordRecovery
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33544, 34)); // {"@type":"requestPasswordRecovery"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RecoverPassword
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33584, 26)); // {"@type":"recoverPassword"
            writer.WriteSpan(StringPool.Slice(33104, 17)); // ,"recovery_code":
            writer.WriteValue(this.recovery_code);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CreateTemporaryPassword
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33616, 34)); // {"@type":"createTemporaryPassword"
            writer.WriteSpan(StringPool.Slice(29280, 12)); // ,"password":
            writer.WriteValue(this.password);
            writer.WriteSpan(StringPool.Slice(1792, 13)); // ,"valid_for":
            writer.WriteValue(this.valid_for);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetTemporaryPasswordState
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33656, 36)); // {"@type":"getTemporaryPasswordState"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ProcessDcUpdate
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33696, 26)); // {"@type":"processDcUpdate"
            writer.WriteSpan(StringPool.Slice(33728, 6)); // ,"dc":
            writer.WriteValue(this.dc);
            writer.WriteSpan(StringPool.Slice(33736, 8)); // ,"addr":
            writer.WriteValue(this.addr);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetMe
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33744, 16)); // {"@type":"getMe"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetUser
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33760, 18)); // {"@type":"getUser"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetUserFullInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33784, 26)); // {"@type":"getUserFullInfo"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetBasicGroup
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33816, 24)); // {"@type":"getBasicGroup"
            writer.WriteSpan(StringPool.Slice(7584, 18)); // ,"basic_group_id":
            writer.WriteValue(this.basic_group_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetBasicGroupFullInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33840, 32)); // {"@type":"getBasicGroupFullInfo"
            writer.WriteSpan(StringPool.Slice(7584, 18)); // ,"basic_group_id":
            writer.WriteValue(this.basic_group_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetSupergroup
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33872, 24)); // {"@type":"getSupergroup"
            writer.WriteSpan(StringPool.Slice(7640, 17)); // ,"supergroup_id":
            writer.WriteValue(this.supergroup_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetSupergroupFullInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33896, 32)); // {"@type":"getSupergroupFullInfo"
            writer.WriteSpan(StringPool.Slice(7640, 17)); // ,"supergroup_id":
            writer.WriteValue(this.supergroup_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetSecretChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33928, 24)); // {"@type":"getSecretChat"
            writer.WriteSpan(StringPool.Slice(7696, 18)); // ,"secret_chat_id":
            writer.WriteValue(this.secret_chat_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33952, 18)); // {"@type":"getChat"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetMessage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(33976, 21)); // {"@type":"getMessage"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetRepliedMessage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34000, 28)); // {"@type":"getRepliedMessage"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetChatPinnedMessage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34032, 31)); // {"@type":"getChatPinnedMessage"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetMessages
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34064, 22)); // {"@type":"getMessages"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            if (this.message_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(30672, 15)); // ,"message_ids":
                writer.WriteArray(this.message_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetFile
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34088, 18)); // {"@type":"getFile"
            writer.WriteSpan(StringPool.Slice(34112, 11)); // ,"file_id":
            writer.WriteValue(this.file_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetRemoteFile
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34128, 24)); // {"@type":"getRemoteFile"
            writer.WriteSpan(StringPool.Slice(34152, 18)); // ,"remote_file_id":
            writer.WriteValue(this.remote_file_id);
            if (this.file_type != null)
            {
                writer.WriteSpan(StringPool.Slice(27856, 13)); // ,"file_type":
                writer.WriteValue(this.file_type);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetChats
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34176, 19)); // {"@type":"getChats"
            writer.WriteSpan(StringPool.Slice(34200, 16)); // ,"offset_order":
            writer.WriteInt64String(this.offset_order);
            writer.WriteSpan(StringPool.Slice(34216, 18)); // ,"offset_chat_id":
            writer.WriteValue(this.offset_chat_id);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchPublicChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34256, 27)); // {"@type":"searchPublicChat"
            writer.WriteSpan(StringPool.Slice(3936, 12)); // ,"username":
            writer.WriteValue(this.username);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchPublicChats
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34288, 28)); // {"@type":"searchPublicChats"
            writer.WriteSpan(StringPool.Slice(5456, 9)); // ,"query":
            writer.WriteValue(this.query);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchChats
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34320, 22)); // {"@type":"searchChats"
            writer.WriteSpan(StringPool.Slice(5456, 9)); // ,"query":
            writer.WriteValue(this.query);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchChatsOnServer
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34344, 30)); // {"@type":"searchChatsOnServer"
            writer.WriteSpan(StringPool.Slice(5456, 9)); // ,"query":
            writer.WriteValue(this.query);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetTopChats
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34376, 22)); // {"@type":"getTopChats"
            if (this.category != null)
            {
                writer.WriteSpan(StringPool.Slice(34400, 12)); // ,"category":
                writer.WriteValue(this.category);
            }
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RemoveTopChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34416, 24)); // {"@type":"removeTopChat"
            if (this.category != null)
            {
                writer.WriteSpan(StringPool.Slice(34400, 12)); // ,"category":
                writer.WriteValue(this.category);
            }
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AddRecentlyFoundChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34440, 31)); // {"@type":"addRecentlyFoundChat"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RemoveRecentlyFoundChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34472, 34)); // {"@type":"removeRecentlyFoundChat"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ClearRecentlyFoundChats
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34512, 34)); // {"@type":"clearRecentlyFoundChats"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CheckChatUsername
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34552, 28)); // {"@type":"checkChatUsername"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteInt64String(this.chat_id);
            writer.WriteSpan(StringPool.Slice(3936, 12)); // ,"username":
            writer.WriteValue(this.username);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetCreatedPublicChats
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34584, 32)); // {"@type":"getCreatedPublicChats"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetGroupsInCommon
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34616, 28)); // {"@type":"getGroupsInCommon"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            writer.WriteSpan(StringPool.Slice(34216, 18)); // ,"offset_chat_id":
            writer.WriteValue(this.offset_chat_id);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetChatHistory
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34648, 25)); // {"@type":"getChatHistory"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(34680, 19)); // ,"from_message_id":
            writer.WriteValue(this.from_message_id);
            writer.WriteSpan(StringPool.Slice(856, 10)); // ,"offset":
            writer.WriteValue(this.offset);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            writer.WriteSpan(StringPool.Slice(34704, 14)); // ,"only_local":
            writer.WriteValue(this.only_local);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeleteChatHistory
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34720, 28)); // {"@type":"deleteChatHistory"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(34752, 25)); // ,"remove_from_chat_list":
            writer.WriteValue(this.remove_from_chat_list);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchChatMessages
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34784, 29)); // {"@type":"searchChatMessages"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(5456, 9)); // ,"query":
            writer.WriteValue(this.query);
            writer.WriteSpan(StringPool.Slice(6440, 18)); // ,"sender_user_id":
            writer.WriteValue(this.sender_user_id);
            writer.WriteSpan(StringPool.Slice(34680, 19)); // ,"from_message_id":
            writer.WriteValue(this.from_message_id);
            writer.WriteSpan(StringPool.Slice(856, 10)); // ,"offset":
            writer.WriteValue(this.offset);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            if (this.filter != null)
            {
                writer.WriteSpan(StringPool.Slice(34816, 10)); // ,"filter":
                writer.WriteValue(this.filter);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchMessages
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34832, 25)); // {"@type":"searchMessages"
            writer.WriteSpan(StringPool.Slice(5456, 9)); // ,"query":
            writer.WriteValue(this.query);
            writer.WriteSpan(StringPool.Slice(34864, 15)); // ,"offset_date":
            writer.WriteValue(this.offset_date);
            writer.WriteSpan(StringPool.Slice(34216, 18)); // ,"offset_chat_id":
            writer.WriteValue(this.offset_chat_id);
            writer.WriteSpan(StringPool.Slice(34880, 21)); // ,"offset_message_id":
            writer.WriteValue(this.offset_message_id);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchSecretMessages
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34904, 31)); // {"@type":"searchSecretMessages"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(5456, 9)); // ,"query":
            writer.WriteValue(this.query);
            writer.WriteSpan(StringPool.Slice(34936, 18)); // ,"from_search_id":
            writer.WriteInt64String(this.from_search_id);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            if (this.filter != null)
            {
                writer.WriteSpan(StringPool.Slice(34816, 10)); // ,"filter":
                writer.WriteValue(this.filter);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchCallMessages
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(34960, 29)); // {"@type":"searchCallMessages"
            writer.WriteSpan(StringPool.Slice(34680, 19)); // ,"from_message_id":
            writer.WriteValue(this.from_message_id);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            writer.WriteSpan(StringPool.Slice(34992, 15)); // ,"only_missed":
            writer.WriteValue(this.only_missed);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchChatRecentLocationMessages
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35008, 43)); // {"@type":"searchChatRecentLocationMessages"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetActiveLiveLocationMessages
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35056, 40)); // {"@type":"getActiveLiveLocationMessages"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetChatMessageByDate
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35096, 31)); // {"@type":"getChatMessageByDate"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(5816, 8)); // ,"date":
            writer.WriteValue(this.date);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetChatMessageCount
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35128, 30)); // {"@type":"getChatMessageCount"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            if (this.filter != null)
            {
                writer.WriteSpan(StringPool.Slice(34816, 10)); // ,"filter":
                writer.WriteValue(this.filter);
            }
            writer.WriteSpan(StringPool.Slice(35160, 16)); // ,"return_local":
            writer.WriteValue(this.return_local);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetPublicMessageLink
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35176, 31)); // {"@type":"getPublicMessageLink"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            writer.WriteSpan(StringPool.Slice(35208, 13)); // ,"for_album":
            writer.WriteValue(this.for_album);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SendMessage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35224, 22)); // {"@type":"sendMessage"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6936, 23)); // ,"reply_to_message_id":
            writer.WriteValue(this.reply_to_message_id);
            writer.WriteSpan(StringPool.Slice(29616, 24)); // ,"disable_notification":
            writer.WriteValue(this.disable_notification);
            writer.WriteSpan(StringPool.Slice(35248, 19)); // ,"from_background":
            writer.WriteValue(this.from_background);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.input_message_content != null)
            {
                writer.WriteSpan(StringPool.Slice(21616, 25)); // ,"input_message_content":
                writer.WriteValue(this.input_message_content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SendMessageAlbum
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35272, 27)); // {"@type":"sendMessageAlbum"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6936, 23)); // ,"reply_to_message_id":
            writer.WriteValue(this.reply_to_message_id);
            writer.WriteSpan(StringPool.Slice(29616, 24)); // ,"disable_notification":
            writer.WriteValue(this.disable_notification);
            writer.WriteSpan(StringPool.Slice(35248, 19)); // ,"from_background":
            writer.WriteValue(this.from_background);
            if (this.input_message_contents != null)
            {
                writer.WriteSpan(StringPool.Slice(35304, 26)); // ,"input_message_contents":
                writer.WriteArray(this.input_message_contents);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SendBotStartMessage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35336, 30)); // {"@type":"sendBotStartMessage"
            writer.WriteSpan(StringPool.Slice(18656, 15)); // ,"bot_user_id":
            writer.WriteValue(this.bot_user_id);
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(35368, 13)); // ,"parameter":
            writer.WriteValue(this.parameter);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SendInlineQueryResultMessage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35384, 39)); // {"@type":"sendInlineQueryResultMessage"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6936, 23)); // ,"reply_to_message_id":
            writer.WriteValue(this.reply_to_message_id);
            writer.WriteSpan(StringPool.Slice(29616, 24)); // ,"disable_notification":
            writer.WriteValue(this.disable_notification);
            writer.WriteSpan(StringPool.Slice(35248, 19)); // ,"from_background":
            writer.WriteValue(this.from_background);
            writer.WriteSpan(StringPool.Slice(35424, 12)); // ,"query_id":
            writer.WriteInt64String(this.query_id);
            writer.WriteSpan(StringPool.Slice(32176, 13)); // ,"result_id":
            writer.WriteValue(this.result_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ForwardMessages
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35440, 26)); // {"@type":"forwardMessages"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(18888, 16)); // ,"from_chat_id":
            writer.WriteValue(this.from_chat_id);
            if (this.message_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(30672, 15)); // ,"message_ids":
                writer.WriteArray(this.message_ids);
            }
            writer.WriteSpan(StringPool.Slice(29616, 24)); // ,"disable_notification":
            writer.WriteValue(this.disable_notification);
            writer.WriteSpan(StringPool.Slice(35248, 19)); // ,"from_background":
            writer.WriteValue(this.from_background);
            writer.WriteSpan(StringPool.Slice(35472, 12)); // ,"as_album":
            writer.WriteValue(this.as_album);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SendChatSetTtlMessage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35488, 32)); // {"@type":"sendChatSetTtlMessage"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6360, 7)); // ,"ttl":
            writer.WriteValue(this.ttl);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SendChatScreenshotTakenNotification
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35520, 46)); // {"@type":"sendChatScreenshotTakenNotification"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AddLocalMessage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35568, 26)); // {"@type":"addLocalMessage"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6440, 18)); // ,"sender_user_id":
            writer.WriteValue(this.sender_user_id);
            writer.WriteSpan(StringPool.Slice(6936, 23)); // ,"reply_to_message_id":
            writer.WriteValue(this.reply_to_message_id);
            writer.WriteSpan(StringPool.Slice(29616, 24)); // ,"disable_notification":
            writer.WriteValue(this.disable_notification);
            if (this.input_message_content != null)
            {
                writer.WriteSpan(StringPool.Slice(21616, 25)); // ,"input_message_content":
                writer.WriteValue(this.input_message_content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeleteMessages
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35600, 25)); // {"@type":"deleteMessages"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            if (this.message_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(30672, 15)); // ,"message_ids":
                writer.WriteArray(this.message_ids);
            }
            writer.WriteSpan(StringPool.Slice(35632, 10)); // ,"revoke":
            writer.WriteValue(this.revoke);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeleteChatMessagesFromUser
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35648, 37)); // {"@type":"deleteChatMessagesFromUser"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class EditMessageText
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35688, 26)); // {"@type":"editMessageText"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.input_message_content != null)
            {
                writer.WriteSpan(StringPool.Slice(21616, 25)); // ,"input_message_content":
                writer.WriteValue(this.input_message_content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class EditMessageLiveLocation
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35720, 34)); // {"@type":"editMessageLiveLocation"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.location != null)
            {
                writer.WriteSpan(StringPool.Slice(3328, 12)); // ,"location":
                writer.WriteValue(this.location);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class EditMessageMedia
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35760, 27)); // {"@type":"editMessageMedia"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.input_message_content != null)
            {
                writer.WriteSpan(StringPool.Slice(21616, 25)); // ,"input_message_content":
                writer.WriteValue(this.input_message_content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class EditMessageCaption
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35792, 29)); // {"@type":"editMessageCaption"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class EditMessageReplyMarkup
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35824, 33)); // {"@type":"editMessageReplyMarkup"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class EditInlineMessageText
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35864, 32)); // {"@type":"editInlineMessageText"
            writer.WriteSpan(StringPool.Slice(32192, 21)); // ,"inline_message_id":
            writer.WriteValue(this.inline_message_id);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.input_message_content != null)
            {
                writer.WriteSpan(StringPool.Slice(21616, 25)); // ,"input_message_content":
                writer.WriteValue(this.input_message_content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class EditInlineMessageLiveLocation
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35896, 40)); // {"@type":"editInlineMessageLiveLocation"
            writer.WriteSpan(StringPool.Slice(32192, 21)); // ,"inline_message_id":
            writer.WriteValue(this.inline_message_id);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.location != null)
            {
                writer.WriteSpan(StringPool.Slice(3328, 12)); // ,"location":
                writer.WriteValue(this.location);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class EditInlineMessageMedia
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35936, 33)); // {"@type":"editInlineMessageMedia"
            writer.WriteSpan(StringPool.Slice(32192, 21)); // ,"inline_message_id":
            writer.WriteValue(this.inline_message_id);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.input_message_content != null)
            {
                writer.WriteSpan(StringPool.Slice(21616, 25)); // ,"input_message_content":
                writer.WriteValue(this.input_message_content);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class EditInlineMessageCaption
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(35976, 35)); // {"@type":"editInlineMessageCaption"
            writer.WriteSpan(StringPool.Slice(32192, 21)); // ,"inline_message_id":
            writer.WriteValue(this.inline_message_id);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            if (this.caption != null)
            {
                writer.WriteSpan(StringPool.Slice(9720, 11)); // ,"caption":
                writer.WriteValue(this.caption);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class EditInlineMessageReplyMarkup
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36016, 39)); // {"@type":"editInlineMessageReplyMarkup"
            writer.WriteSpan(StringPool.Slice(32192, 21)); // ,"inline_message_id":
            writer.WriteValue(this.inline_message_id);
            if (this.reply_markup != null)
            {
                writer.WriteSpan(StringPool.Slice(7064, 16)); // ,"reply_markup":
                writer.WriteValue(this.reply_markup);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetTextEntities
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36056, 26)); // {"@type":"getTextEntities"
            writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
            writer.WriteValue(this.text);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ParseTextEntities
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36088, 28)); // {"@type":"parseTextEntities"
            writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
            writer.WriteValue(this.text);
            if (this.parse_mode != null)
            {
                writer.WriteSpan(StringPool.Slice(36120, 14)); // ,"parse_mode":
                writer.WriteValue(this.parse_mode);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetFileMimeType
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36136, 26)); // {"@type":"getFileMimeType"
            writer.WriteSpan(StringPool.Slice(2672, 13)); // ,"file_name":
            writer.WriteValue(this.file_name);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetFileExtension
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36168, 27)); // {"@type":"getFileExtension"
            writer.WriteSpan(StringPool.Slice(2688, 13)); // ,"mime_type":
            writer.WriteValue(this.mime_type);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CleanFileName
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36200, 24)); // {"@type":"cleanFileName"
            writer.WriteSpan(StringPool.Slice(2672, 13)); // ,"file_name":
            writer.WriteValue(this.file_name);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetLanguagePackString
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36224, 32)); // {"@type":"getLanguagePackString"
            writer.WriteSpan(StringPool.Slice(36256, 31)); // ,"language_pack_database_path":
            writer.WriteValue(this.language_pack_database_path);
            writer.WriteSpan(StringPool.Slice(31944, 23)); // ,"localization_target":
            writer.WriteValue(this.localization_target);
            writer.WriteSpan(StringPool.Slice(31968, 20)); // ,"language_pack_id":
            writer.WriteValue(this.language_pack_id);
            writer.WriteSpan(StringPool.Slice(24920, 7)); // ,"key":
            writer.WriteValue(this.key);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetInlineQueryResults
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36288, 32)); // {"@type":"getInlineQueryResults"
            writer.WriteSpan(StringPool.Slice(18656, 15)); // ,"bot_user_id":
            writer.WriteValue(this.bot_user_id);
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            if (this.user_location != null)
            {
                writer.WriteSpan(StringPool.Slice(32112, 17)); // ,"user_location":
                writer.WriteValue(this.user_location);
            }
            writer.WriteSpan(StringPool.Slice(5456, 9)); // ,"query":
            writer.WriteValue(this.query);
            writer.WriteSpan(StringPool.Slice(856, 10)); // ,"offset":
            writer.WriteValue(this.offset);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AnswerInlineQuery
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36320, 28)); // {"@type":"answerInlineQuery"
            writer.WriteSpan(StringPool.Slice(23040, 19)); // ,"inline_query_id":
            writer.WriteInt64String(this.inline_query_id);
            writer.WriteSpan(StringPool.Slice(8728, 15)); // ,"is_personal":
            writer.WriteValue(this.is_personal);
            if (this.results != null)
            {
                writer.WriteSpan(StringPool.Slice(23080, 11)); // ,"results":
                writer.WriteArray(this.results);
            }
            writer.WriteSpan(StringPool.Slice(36352, 14)); // ,"cache_time":
            writer.WriteValue(this.cache_time);
            writer.WriteSpan(StringPool.Slice(23064, 15)); // ,"next_offset":
            writer.WriteValue(this.next_offset);
            writer.WriteSpan(StringPool.Slice(23096, 18)); // ,"switch_pm_text":
            writer.WriteValue(this.switch_pm_text);
            writer.WriteSpan(StringPool.Slice(23120, 23)); // ,"switch_pm_parameter":
            writer.WriteValue(this.switch_pm_parameter);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetCallbackQueryAnswer
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36368, 33)); // {"@type":"getCallbackQueryAnswer"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            if (this.payload != null)
            {
                writer.WriteSpan(StringPool.Slice(18792, 11)); // ,"payload":
                writer.WriteValue(this.payload);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AnswerCallbackQuery
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36408, 30)); // {"@type":"answerCallbackQuery"
            writer.WriteSpan(StringPool.Slice(36440, 21)); // ,"callback_query_id":
            writer.WriteInt64String(this.callback_query_id);
            writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
            writer.WriteValue(this.text);
            writer.WriteSpan(StringPool.Slice(23256, 14)); // ,"show_alert":
            writer.WriteValue(this.show_alert);
            writer.WriteSpan(StringPool.Slice(8432, 7)); // ,"url":
            writer.WriteValue(this.url);
            writer.WriteSpan(StringPool.Slice(36352, 14)); // ,"cache_time":
            writer.WriteValue(this.cache_time);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AnswerShippingQuery
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36464, 30)); // {"@type":"answerShippingQuery"
            writer.WriteSpan(StringPool.Slice(36496, 21)); // ,"shipping_query_id":
            writer.WriteInt64String(this.shipping_query_id);
            if (this.shipping_options != null)
            {
                writer.WriteSpan(StringPool.Slice(11536, 20)); // ,"shipping_options":
                writer.WriteArray(this.shipping_options);
            }
            writer.WriteSpan(StringPool.Slice(29824, 17)); // ,"error_message":
            writer.WriteValue(this.error_message);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AnswerPreCheckoutQuery
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36520, 33)); // {"@type":"answerPreCheckoutQuery"
            writer.WriteSpan(StringPool.Slice(36560, 25)); // ,"pre_checkout_query_id":
            writer.WriteInt64String(this.pre_checkout_query_id);
            writer.WriteSpan(StringPool.Slice(29824, 17)); // ,"error_message":
            writer.WriteValue(this.error_message);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetGameScore
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36592, 23)); // {"@type":"setGameScore"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            writer.WriteSpan(StringPool.Slice(36616, 16)); // ,"edit_message":
            writer.WriteValue(this.edit_message);
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            writer.WriteSpan(StringPool.Slice(17176, 9)); // ,"score":
            writer.WriteValue(this.score);
            writer.WriteSpan(StringPool.Slice(36632, 9)); // ,"force":
            writer.WriteValue(this.force);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetInlineGameScore
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36648, 29)); // {"@type":"setInlineGameScore"
            writer.WriteSpan(StringPool.Slice(32192, 21)); // ,"inline_message_id":
            writer.WriteValue(this.inline_message_id);
            writer.WriteSpan(StringPool.Slice(36616, 16)); // ,"edit_message":
            writer.WriteValue(this.edit_message);
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            writer.WriteSpan(StringPool.Slice(17176, 9)); // ,"score":
            writer.WriteValue(this.score);
            writer.WriteSpan(StringPool.Slice(36632, 9)); // ,"force":
            writer.WriteValue(this.force);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetGameHighScores
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36680, 28)); // {"@type":"getGameHighScores"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetInlineGameHighScores
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36712, 34)); // {"@type":"getInlineGameHighScores"
            writer.WriteSpan(StringPool.Slice(32192, 21)); // ,"inline_message_id":
            writer.WriteValue(this.inline_message_id);
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeleteChatReplyMarkup
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36752, 32)); // {"@type":"deleteChatReplyMarkup"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SendChatAction
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36784, 25)); // {"@type":"sendChatAction"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            if (this.action != null)
            {
                writer.WriteSpan(StringPool.Slice(24344, 10)); // ,"action":
                writer.WriteValue(this.action);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class OpenChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36816, 19)); // {"@type":"openChat"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CloseChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36840, 20)); // {"@type":"closeChat"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ViewMessages
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36864, 23)); // {"@type":"viewMessages"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            if (this.message_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(30672, 15)); // ,"message_ids":
                writer.WriteArray(this.message_ids);
            }
            writer.WriteSpan(StringPool.Slice(36888, 14)); // ,"force_read":
            writer.WriteValue(this.force_read);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class OpenMessageContent
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36904, 29)); // {"@type":"openMessageContent"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ReadAllChatMentions
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36936, 30)); // {"@type":"readAllChatMentions"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CreatePrivateChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(36968, 28)); // {"@type":"createPrivateChat"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            writer.WriteSpan(StringPool.Slice(36632, 9)); // ,"force":
            writer.WriteValue(this.force);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CreateBasicGroupChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37000, 31)); // {"@type":"createBasicGroupChat"
            writer.WriteSpan(StringPool.Slice(7584, 18)); // ,"basic_group_id":
            writer.WriteValue(this.basic_group_id);
            writer.WriteSpan(StringPool.Slice(36632, 9)); // ,"force":
            writer.WriteValue(this.force);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CreateSupergroupChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37032, 31)); // {"@type":"createSupergroupChat"
            writer.WriteSpan(StringPool.Slice(7640, 17)); // ,"supergroup_id":
            writer.WriteValue(this.supergroup_id);
            writer.WriteSpan(StringPool.Slice(36632, 9)); // ,"force":
            writer.WriteValue(this.force);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CreateSecretChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37064, 27)); // {"@type":"createSecretChat"
            writer.WriteSpan(StringPool.Slice(7696, 18)); // ,"secret_chat_id":
            writer.WriteValue(this.secret_chat_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CreateNewBasicGroupChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37096, 34)); // {"@type":"createNewBasicGroupChat"
            if (this.user_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(4360, 12)); // ,"user_ids":
                writer.WriteArray(this.user_ids);
            }
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CreateNewSupergroupChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37136, 34)); // {"@type":"createNewSupergroupChat"
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(5872, 14)); // ,"is_channel":
            writer.WriteValue(this.is_channel);
            writer.WriteSpan(StringPool.Slice(3408, 15)); // ,"description":
            writer.WriteValue(this.description);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CreateNewSecretChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37176, 30)); // {"@type":"createNewSecretChat"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UpgradeBasicGroupChatToSupergroupChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37208, 48)); // {"@type":"upgradeBasicGroupChatToSupergroupChat"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetChatTitle
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37256, 23)); // {"@type":"setChatTitle"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetChatPhoto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37280, 23)); // {"@type":"setChatPhoto"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            if (this.photo != null)
            {
                writer.WriteSpan(StringPool.Slice(2384, 9)); // ,"photo":
                writer.WriteValue(this.photo);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetChatDraftMessage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37304, 30)); // {"@type":"setChatDraftMessage"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            if (this.draft_message != null)
            {
                writer.WriteSpan(StringPool.Slice(8048, 17)); // ,"draft_message":
                writer.WriteValue(this.draft_message);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetChatNotificationSettings
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37336, 38)); // {"@type":"setChatNotificationSettings"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            if (this.notification_settings != null)
            {
                writer.WriteSpan(StringPool.Slice(7984, 25)); // ,"notification_settings":
                writer.WriteValue(this.notification_settings);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ToggleChatIsPinned
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37376, 29)); // {"@type":"toggleChatIsPinned"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(7768, 13)); // ,"is_pinned":
            writer.WriteValue(this.is_pinned);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ToggleChatIsMarkedAsUnread
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37408, 37)); // {"@type":"toggleChatIsMarkedAsUnread"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(7784, 23)); // ,"is_marked_as_unread":
            writer.WriteValue(this.is_marked_as_unread);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ToggleChatDefaultDisableNotification
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37448, 47)); // {"@type":"toggleChatDefaultDisableNotification"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(7848, 32)); // ,"default_disable_notification":
            writer.WriteValue(this.default_disable_notification);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetChatClientData
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37496, 28)); // {"@type":"setChatClientData"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(8072, 15)); // ,"client_data":
            writer.WriteValue(this.client_data);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class JoinChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37528, 19)); // {"@type":"joinChat"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class LeaveChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37552, 20)); // {"@type":"leaveChat"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AddChatMember
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37576, 24)); // {"@type":"addChatMember"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            writer.WriteSpan(StringPool.Slice(37600, 17)); // ,"forward_limit":
            writer.WriteValue(this.forward_limit);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AddChatMembers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37624, 25)); // {"@type":"addChatMembers"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            if (this.user_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(4360, 12)); // ,"user_ids":
                writer.WriteArray(this.user_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetChatMemberStatus
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37656, 30)); // {"@type":"setChatMemberStatus"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            if (this.status != null)
            {
                writer.WriteSpan(StringPool.Slice(3952, 10)); // ,"status":
                writer.WriteValue(this.status);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetChatMember
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37688, 24)); // {"@type":"getChatMember"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchChatMembers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37712, 28)); // {"@type":"searchChatMembers"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(5456, 9)); // ,"query":
            writer.WriteValue(this.query);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            if (this.filter != null)
            {
                writer.WriteSpan(StringPool.Slice(34816, 10)); // ,"filter":
                writer.WriteValue(this.filter);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetChatAdministrators
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37744, 32)); // {"@type":"getChatAdministrators"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ClearAllDraftMessages
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37776, 32)); // {"@type":"clearAllDraftMessages"
            writer.WriteSpan(StringPool.Slice(37808, 24)); // ,"exclude_secret_chats":
            writer.WriteValue(this.exclude_secret_chats);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetScopeNotificationSettings
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37832, 39)); // {"@type":"getScopeNotificationSettings"
            if (this.scope != null)
            {
                writer.WriteSpan(StringPool.Slice(30552, 9)); // ,"scope":
                writer.WriteValue(this.scope);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetScopeNotificationSettings
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37872, 39)); // {"@type":"setScopeNotificationSettings"
            if (this.scope != null)
            {
                writer.WriteSpan(StringPool.Slice(30552, 9)); // ,"scope":
                writer.WriteValue(this.scope);
            }
            if (this.notification_settings != null)
            {
                writer.WriteSpan(StringPool.Slice(7984, 25)); // ,"notification_settings":
                writer.WriteValue(this.notification_settings);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ResetAllNotificationSettings
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37912, 39)); // {"@type":"resetAllNotificationSettings"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetPinnedChats
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37952, 25)); // {"@type":"setPinnedChats"
            if (this.chat_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(8104, 12)); // ,"chat_ids":
                writer.WriteArray(this.chat_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DownloadFile
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(37984, 23)); // {"@type":"downloadFile"
            writer.WriteSpan(StringPool.Slice(34112, 11)); // ,"file_id":
            writer.WriteValue(this.file_id);
            writer.WriteSpan(StringPool.Slice(38008, 12)); // ,"priority":
            writer.WriteValue(this.priority);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CancelDownloadFile
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38024, 29)); // {"@type":"cancelDownloadFile"
            writer.WriteSpan(StringPool.Slice(34112, 11)); // ,"file_id":
            writer.WriteValue(this.file_id);
            writer.WriteSpan(StringPool.Slice(38056, 19)); // ,"only_if_pending":
            writer.WriteValue(this.only_if_pending);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UploadFile
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38080, 21)); // {"@type":"uploadFile"
            if (this.file != null)
            {
                writer.WriteSpan(StringPool.Slice(11776, 8)); // ,"file":
                writer.WriteValue(this.file);
            }
            if (this.file_type != null)
            {
                writer.WriteSpan(StringPool.Slice(27856, 13)); // ,"file_type":
                writer.WriteValue(this.file_type);
            }
            writer.WriteSpan(StringPool.Slice(38008, 12)); // ,"priority":
            writer.WriteValue(this.priority);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CancelUploadFile
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38104, 27)); // {"@type":"cancelUploadFile"
            writer.WriteSpan(StringPool.Slice(34112, 11)); // ,"file_id":
            writer.WriteValue(this.file_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetFileGenerationProgress
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38136, 36)); // {"@type":"setFileGenerationProgress"
            writer.WriteSpan(StringPool.Slice(31256, 17)); // ,"generation_id":
            writer.WriteInt64String(this.generation_id);
            writer.WriteSpan(StringPool.Slice(2144, 17)); // ,"expected_size":
            writer.WriteValue(this.expected_size);
            writer.WriteSpan(StringPool.Slice(38176, 21)); // ,"local_prefix_size":
            writer.WriteValue(this.local_prefix_size);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class FinishFileGeneration
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38200, 31)); // {"@type":"finishFileGeneration"
            writer.WriteSpan(StringPool.Slice(31256, 17)); // ,"generation_id":
            writer.WriteInt64String(this.generation_id);
            if (this.error != null)
            {
                writer.WriteSpan(StringPool.Slice(21352, 9)); // ,"error":
                writer.WriteValue(this.error);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeleteFile
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38232, 21)); // {"@type":"deleteFile"
            writer.WriteSpan(StringPool.Slice(34112, 11)); // ,"file_id":
            writer.WriteValue(this.file_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GenerateChatInviteLink
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38256, 33)); // {"@type":"generateChatInviteLink"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CheckChatInviteLink
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38296, 30)); // {"@type":"checkChatInviteLink"
            writer.WriteSpan(StringPool.Slice(5776, 15)); // ,"invite_link":
            writer.WriteValue(this.invite_link);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class JoinChatByInviteLink
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38328, 31)); // {"@type":"joinChatByInviteLink"
            writer.WriteSpan(StringPool.Slice(5776, 15)); // ,"invite_link":
            writer.WriteValue(this.invite_link);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CreateCall
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38360, 21)); // {"@type":"createCall"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            if (this.protocol != null)
            {
                writer.WriteSpan(StringPool.Slice(21120, 12)); // ,"protocol":
                writer.WriteValue(this.protocol);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AcceptCall
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38384, 21)); // {"@type":"acceptCall"
            writer.WriteSpan(StringPool.Slice(38408, 11)); // ,"call_id":
            writer.WriteValue(this.call_id);
            if (this.protocol != null)
            {
                writer.WriteSpan(StringPool.Slice(21120, 12)); // ,"protocol":
                writer.WriteValue(this.protocol);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DiscardCall
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38424, 22)); // {"@type":"discardCall"
            writer.WriteSpan(StringPool.Slice(38408, 11)); // ,"call_id":
            writer.WriteValue(this.call_id);
            writer.WriteSpan(StringPool.Slice(38448, 19)); // ,"is_disconnected":
            writer.WriteValue(this.is_disconnected);
            writer.WriteSpan(StringPool.Slice(2656, 12)); // ,"duration":
            writer.WriteValue(this.duration);
            writer.WriteSpan(StringPool.Slice(38472, 17)); // ,"connection_id":
            writer.WriteInt64String(this.connection_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SendCallRating
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38496, 25)); // {"@type":"sendCallRating"
            writer.WriteSpan(StringPool.Slice(38408, 11)); // ,"call_id":
            writer.WriteValue(this.call_id);
            writer.WriteSpan(StringPool.Slice(38528, 10)); // ,"rating":
            writer.WriteValue(this.rating);
            writer.WriteSpan(StringPool.Slice(38544, 11)); // ,"comment":
            writer.WriteValue(this.comment);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SendCallDebugInformation
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38560, 35)); // {"@type":"sendCallDebugInformation"
            writer.WriteSpan(StringPool.Slice(38408, 11)); // ,"call_id":
            writer.WriteValue(this.call_id);
            writer.WriteSpan(StringPool.Slice(38600, 21)); // ,"debug_information":
            writer.WriteValue(this.debug_information);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class BlockUser
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38624, 20)); // {"@type":"blockUser"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UnblockUser
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38648, 22)); // {"@type":"unblockUser"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetBlockedUsers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38672, 26)); // {"@type":"getBlockedUsers"
            writer.WriteSpan(StringPool.Slice(856, 10)); // ,"offset":
            writer.WriteValue(this.offset);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ImportContacts
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38704, 25)); // {"@type":"importContacts"
            if (this.contacts != null)
            {
                writer.WriteSpan(StringPool.Slice(38736, 12)); // ,"contacts":
                writer.WriteArray(this.contacts);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetContacts
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38752, 22)); // {"@type":"getContacts"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchContacts
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38776, 25)); // {"@type":"searchContacts"
            writer.WriteSpan(StringPool.Slice(5456, 9)); // ,"query":
            writer.WriteValue(this.query);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RemoveContacts
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38808, 25)); // {"@type":"removeContacts"
            if (this.user_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(4360, 12)); // ,"user_ids":
                writer.WriteArray(this.user_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetImportedContactCount
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38840, 34)); // {"@type":"getImportedContactCount"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChangeImportedContacts
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38880, 33)); // {"@type":"changeImportedContacts"
            if (this.contacts != null)
            {
                writer.WriteSpan(StringPool.Slice(38736, 12)); // ,"contacts":
                writer.WriteArray(this.contacts);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ClearImportedContacts
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38920, 32)); // {"@type":"clearImportedContacts"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetUserProfilePhotos
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38952, 31)); // {"@type":"getUserProfilePhotos"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            writer.WriteSpan(StringPool.Slice(856, 10)); // ,"offset":
            writer.WriteValue(this.offset);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetStickers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(38984, 22)); // {"@type":"getStickers"
            writer.WriteSpan(StringPool.Slice(2960, 9)); // ,"emoji":
            writer.WriteValue(this.emoji);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchStickers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39008, 25)); // {"@type":"searchStickers"
            writer.WriteSpan(StringPool.Slice(2960, 9)); // ,"emoji":
            writer.WriteValue(this.emoji);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetInstalledStickerSets
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39040, 34)); // {"@type":"getInstalledStickerSets"
            writer.WriteSpan(StringPool.Slice(20496, 12)); // ,"is_masks":
            writer.WriteValue(this.is_masks);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetArchivedStickerSets
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39080, 33)); // {"@type":"getArchivedStickerSets"
            writer.WriteSpan(StringPool.Slice(20496, 12)); // ,"is_masks":
            writer.WriteValue(this.is_masks);
            writer.WriteSpan(StringPool.Slice(39120, 25)); // ,"offset_sticker_set_id":
            writer.WriteInt64String(this.offset_sticker_set_id);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetTrendingStickerSets
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39152, 33)); // {"@type":"getTrendingStickerSets"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetAttachedStickerSets
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39192, 33)); // {"@type":"getAttachedStickerSets"
            writer.WriteSpan(StringPool.Slice(34112, 11)); // ,"file_id":
            writer.WriteValue(this.file_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetStickerSet
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39232, 24)); // {"@type":"getStickerSet"
            writer.WriteSpan(StringPool.Slice(2944, 10)); // ,"set_id":
            writer.WriteInt64String(this.set_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchStickerSet
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39256, 27)); // {"@type":"searchStickerSet"
            writer.WriteSpan(StringPool.Slice(9624, 8)); // ,"name":
            writer.WriteValue(this.name);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchInstalledStickerSets
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39288, 37)); // {"@type":"searchInstalledStickerSets"
            writer.WriteSpan(StringPool.Slice(20496, 12)); // ,"is_masks":
            writer.WriteValue(this.is_masks);
            writer.WriteSpan(StringPool.Slice(5456, 9)); // ,"query":
            writer.WriteValue(this.query);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchStickerSets
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39328, 28)); // {"@type":"searchStickerSets"
            writer.WriteSpan(StringPool.Slice(5456, 9)); // ,"query":
            writer.WriteValue(this.query);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChangeStickerSet
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39360, 27)); // {"@type":"changeStickerSet"
            writer.WriteSpan(StringPool.Slice(2944, 10)); // ,"set_id":
            writer.WriteInt64String(this.set_id);
            writer.WriteSpan(StringPool.Slice(20448, 16)); // ,"is_installed":
            writer.WriteValue(this.is_installed);
            writer.WriteSpan(StringPool.Slice(20464, 15)); // ,"is_archived":
            writer.WriteValue(this.is_archived);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ViewTrendingStickerSets
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39392, 34)); // {"@type":"viewTrendingStickerSets"
            if (this.sticker_set_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(31664, 19)); // ,"sticker_set_ids":
                writer.WriteInt64Array(this.sticker_set_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ReorderInstalledStickerSets
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39432, 38)); // {"@type":"reorderInstalledStickerSets"
            writer.WriteSpan(StringPool.Slice(20496, 12)); // ,"is_masks":
            writer.WriteValue(this.is_masks);
            if (this.sticker_set_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(31664, 19)); // ,"sticker_set_ids":
                writer.WriteInt64Array(this.sticker_set_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetRecentStickers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39472, 28)); // {"@type":"getRecentStickers"
            writer.WriteSpan(StringPool.Slice(31776, 15)); // ,"is_attached":
            writer.WriteValue(this.is_attached);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AddRecentSticker
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39504, 27)); // {"@type":"addRecentSticker"
            writer.WriteSpan(StringPool.Slice(31776, 15)); // ,"is_attached":
            writer.WriteValue(this.is_attached);
            if (this.sticker != null)
            {
                writer.WriteSpan(StringPool.Slice(3016, 11)); // ,"sticker":
                writer.WriteValue(this.sticker);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RemoveRecentSticker
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39536, 30)); // {"@type":"removeRecentSticker"
            writer.WriteSpan(StringPool.Slice(31776, 15)); // ,"is_attached":
            writer.WriteValue(this.is_attached);
            if (this.sticker != null)
            {
                writer.WriteSpan(StringPool.Slice(3016, 11)); // ,"sticker":
                writer.WriteValue(this.sticker);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ClearRecentStickers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39568, 30)); // {"@type":"clearRecentStickers"
            writer.WriteSpan(StringPool.Slice(31776, 15)); // ,"is_attached":
            writer.WriteValue(this.is_attached);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetFavoriteStickers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39600, 30)); // {"@type":"getFavoriteStickers"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AddFavoriteSticker
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39632, 29)); // {"@type":"addFavoriteSticker"
            if (this.sticker != null)
            {
                writer.WriteSpan(StringPool.Slice(3016, 11)); // ,"sticker":
                writer.WriteValue(this.sticker);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RemoveFavoriteSticker
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39664, 32)); // {"@type":"removeFavoriteSticker"
            if (this.sticker != null)
            {
                writer.WriteSpan(StringPool.Slice(3016, 11)); // ,"sticker":
                writer.WriteValue(this.sticker);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetStickerEmojis
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39696, 27)); // {"@type":"getStickerEmojis"
            if (this.sticker != null)
            {
                writer.WriteSpan(StringPool.Slice(3016, 11)); // ,"sticker":
                writer.WriteValue(this.sticker);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetSavedAnimations
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39728, 29)); // {"@type":"getSavedAnimations"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AddSavedAnimation
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39760, 28)); // {"@type":"addSavedAnimation"
            if (this.animation != null)
            {
                writer.WriteSpan(StringPool.Slice(2720, 13)); // ,"animation":
                writer.WriteValue(this.animation);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RemoveSavedAnimation
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39792, 31)); // {"@type":"removeSavedAnimation"
            if (this.animation != null)
            {
                writer.WriteSpan(StringPool.Slice(2720, 13)); // ,"animation":
                writer.WriteValue(this.animation);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetRecentInlineBots
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39824, 30)); // {"@type":"getRecentInlineBots"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SearchHashtags
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39856, 25)); // {"@type":"searchHashtags"
            writer.WriteSpan(StringPool.Slice(39888, 10)); // ,"prefix":
            writer.WriteValue(this.prefix);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RemoveRecentHashtag
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39904, 30)); // {"@type":"removeRecentHashtag"
            writer.WriteSpan(StringPool.Slice(39936, 11)); // ,"hashtag":
            writer.WriteValue(this.hashtag);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetWebPagePreview
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39952, 28)); // {"@type":"getWebPagePreview"
            if (this.text != null)
            {
                writer.WriteSpan(StringPool.Slice(936, 8)); // ,"text":
                writer.WriteValue(this.text);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetWebPageInstantView
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(39984, 32)); // {"@type":"getWebPageInstantView"
            writer.WriteSpan(StringPool.Slice(8432, 7)); // ,"url":
            writer.WriteValue(this.url);
            writer.WriteSpan(StringPool.Slice(40016, 14)); // ,"force_full":
            writer.WriteValue(this.force_full);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetProfilePhoto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40032, 26)); // {"@type":"setProfilePhoto"
            if (this.photo != null)
            {
                writer.WriteSpan(StringPool.Slice(2384, 9)); // ,"photo":
                writer.WriteValue(this.photo);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeleteProfilePhoto
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40064, 29)); // {"@type":"deleteProfilePhoto"
            writer.WriteSpan(StringPool.Slice(40096, 20)); // ,"profile_photo_id":
            writer.WriteInt64String(this.profile_photo_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetName
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40120, 18)); // {"@type":"setName"
            writer.WriteSpan(StringPool.Slice(3192, 14)); // ,"first_name":
            writer.WriteValue(this.first_name);
            writer.WriteSpan(StringPool.Slice(3208, 13)); // ,"last_name":
            writer.WriteValue(this.last_name);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetBio
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40144, 17)); // {"@type":"setBio"
            writer.WriteSpan(StringPool.Slice(4208, 7)); // ,"bio":
            writer.WriteValue(this.bio);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetUsername
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40168, 22)); // {"@type":"setUsername"
            writer.WriteSpan(StringPool.Slice(3936, 12)); // ,"username":
            writer.WriteValue(this.username);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChangePhoneNumber
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40192, 28)); // {"@type":"changePhoneNumber"
            writer.WriteSpan(StringPool.Slice(696, 16)); // ,"phone_number":
            writer.WriteValue(this.phone_number);
            writer.WriteSpan(StringPool.Slice(32840, 20)); // ,"allow_flash_call":
            writer.WriteValue(this.allow_flash_call);
            writer.WriteSpan(StringPool.Slice(32864, 27)); // ,"is_current_phone_number":
            writer.WriteValue(this.is_current_phone_number);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ResendChangePhoneNumberCode
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40224, 38)); // {"@type":"resendChangePhoneNumberCode"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CheckChangePhoneNumberCode
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40264, 37)); // {"@type":"checkChangePhoneNumberCode"
            writer.WriteSpan(StringPool.Slice(32, 8)); // ,"code":
            writer.WriteValue(this.code);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetActiveSessions
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40304, 28)); // {"@type":"getActiveSessions"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TerminateSession
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40336, 27)); // {"@type":"terminateSession"
            writer.WriteSpan(StringPool.Slice(40368, 14)); // ,"session_id":
            writer.WriteInt64String(this.session_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TerminateAllOtherSessions
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40384, 36)); // {"@type":"terminateAllOtherSessions"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetConnectedWebsites
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40424, 31)); // {"@type":"getConnectedWebsites"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DisconnectWebsite
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40456, 28)); // {"@type":"disconnectWebsite"
            writer.WriteSpan(StringPool.Slice(40488, 14)); // ,"website_id":
            writer.WriteInt64String(this.website_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DisconnectAllWebsites
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40504, 32)); // {"@type":"disconnectAllWebsites"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ToggleBasicGroupAdministrators
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40536, 41)); // {"@type":"toggleBasicGroupAdministrators"
            writer.WriteSpan(StringPool.Slice(7584, 18)); // ,"basic_group_id":
            writer.WriteValue(this.basic_group_id);
            writer.WriteSpan(StringPool.Slice(5640, 29)); // ,"everyone_is_administrator":
            writer.WriteValue(this.everyone_is_administrator);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetSupergroupUsername
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40584, 32)); // {"@type":"setSupergroupUsername"
            writer.WriteSpan(StringPool.Slice(7640, 17)); // ,"supergroup_id":
            writer.WriteValue(this.supergroup_id);
            writer.WriteSpan(StringPool.Slice(3936, 12)); // ,"username":
            writer.WriteValue(this.username);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetSupergroupStickerSet
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40616, 34)); // {"@type":"setSupergroupStickerSet"
            writer.WriteSpan(StringPool.Slice(7640, 17)); // ,"supergroup_id":
            writer.WriteValue(this.supergroup_id);
            writer.WriteSpan(StringPool.Slice(6088, 18)); // ,"sticker_set_id":
            writer.WriteInt64String(this.sticker_set_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ToggleSupergroupInvites
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40656, 34)); // {"@type":"toggleSupergroupInvites"
            writer.WriteSpan(StringPool.Slice(7640, 17)); // ,"supergroup_id":
            writer.WriteValue(this.supergroup_id);
            writer.WriteSpan(StringPool.Slice(5824, 21)); // ,"anyone_can_invite":
            writer.WriteValue(this.anyone_can_invite);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ToggleSupergroupSignMessages
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40696, 39)); // {"@type":"toggleSupergroupSignMessages"
            writer.WriteSpan(StringPool.Slice(7640, 17)); // ,"supergroup_id":
            writer.WriteValue(this.supergroup_id);
            writer.WriteSpan(StringPool.Slice(5848, 17)); // ,"sign_messages":
            writer.WriteValue(this.sign_messages);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ToggleSupergroupIsAllHistoryAvailable
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40736, 48)); // {"@type":"toggleSupergroupIsAllHistoryAvailable"
            writer.WriteSpan(StringPool.Slice(7640, 17)); // ,"supergroup_id":
            writer.WriteValue(this.supergroup_id);
            writer.WriteSpan(StringPool.Slice(6056, 28)); // ,"is_all_history_available":
            writer.WriteValue(this.is_all_history_available);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetSupergroupDescription
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40784, 35)); // {"@type":"setSupergroupDescription"
            writer.WriteSpan(StringPool.Slice(7640, 17)); // ,"supergroup_id":
            writer.WriteValue(this.supergroup_id);
            writer.WriteSpan(StringPool.Slice(3408, 15)); // ,"description":
            writer.WriteValue(this.description);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PinSupergroupMessage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40824, 31)); // {"@type":"pinSupergroupMessage"
            writer.WriteSpan(StringPool.Slice(7640, 17)); // ,"supergroup_id":
            writer.WriteValue(this.supergroup_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            writer.WriteSpan(StringPool.Slice(29616, 24)); // ,"disable_notification":
            writer.WriteValue(this.disable_notification);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UnpinSupergroupMessage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40856, 33)); // {"@type":"unpinSupergroupMessage"
            writer.WriteSpan(StringPool.Slice(7640, 17)); // ,"supergroup_id":
            writer.WriteValue(this.supergroup_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ReportSupergroupSpam
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40896, 31)); // {"@type":"reportSupergroupSpam"
            writer.WriteSpan(StringPool.Slice(7640, 17)); // ,"supergroup_id":
            writer.WriteValue(this.supergroup_id);
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            if (this.message_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(30672, 15)); // ,"message_ids":
                writer.WriteArray(this.message_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetSupergroupMembers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40928, 31)); // {"@type":"getSupergroupMembers"
            writer.WriteSpan(StringPool.Slice(7640, 17)); // ,"supergroup_id":
            writer.WriteValue(this.supergroup_id);
            if (this.filter != null)
            {
                writer.WriteSpan(StringPool.Slice(34816, 10)); // ,"filter":
                writer.WriteValue(this.filter);
            }
            writer.WriteSpan(StringPool.Slice(856, 10)); // ,"offset":
            writer.WriteValue(this.offset);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeleteSupergroup
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40960, 27)); // {"@type":"deleteSupergroup"
            writer.WriteSpan(StringPool.Slice(7640, 17)); // ,"supergroup_id":
            writer.WriteValue(this.supergroup_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CloseSecretChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(40992, 26)); // {"@type":"closeSecretChat"
            writer.WriteSpan(StringPool.Slice(7696, 18)); // ,"secret_chat_id":
            writer.WriteValue(this.secret_chat_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetChatEventLog
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41024, 26)); // {"@type":"getChatEventLog"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(5456, 9)); // ,"query":
            writer.WriteValue(this.query);
            writer.WriteSpan(StringPool.Slice(41056, 17)); // ,"from_event_id":
            writer.WriteInt64String(this.from_event_id);
            writer.WriteSpan(StringPool.Slice(34240, 9)); // ,"limit":
            writer.WriteValue(this.limit);
            if (this.filters != null)
            {
                writer.WriteSpan(StringPool.Slice(41080, 11)); // ,"filters":
                writer.WriteValue(this.filters);
            }
            if (this.user_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(4360, 12)); // ,"user_ids":
                writer.WriteArray(this.user_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetPaymentForm
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41096, 25)); // {"@type":"getPaymentForm"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ValidateOrderInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41128, 28)); // {"@type":"validateOrderInfo"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            if (this.order_info != null)
            {
                writer.WriteSpan(StringPool.Slice(11688, 14)); // ,"order_info":
                writer.WriteValue(this.order_info);
            }
            writer.WriteSpan(StringPool.Slice(11096, 14)); // ,"allow_save":
            writer.WriteValue(this.allow_save);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SendPaymentForm
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41160, 26)); // {"@type":"sendPaymentForm"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            writer.WriteSpan(StringPool.Slice(11512, 17)); // ,"order_info_id":
            writer.WriteValue(this.order_info_id);
            writer.WriteSpan(StringPool.Slice(17320, 22)); // ,"shipping_option_id":
            writer.WriteValue(this.shipping_option_id);
            if (this.credentials != null)
            {
                writer.WriteSpan(StringPool.Slice(17600, 15)); // ,"credentials":
                writer.WriteValue(this.credentials);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetPaymentReceipt
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41192, 28)); // {"@type":"getPaymentReceipt"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(6600, 14)); // ,"message_id":
            writer.WriteValue(this.message_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetSavedOrderInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41224, 28)); // {"@type":"getSavedOrderInfo"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeleteSavedOrderInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41256, 31)); // {"@type":"deleteSavedOrderInfo"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeleteSavedCredentials
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41288, 33)); // {"@type":"deleteSavedCredentials"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetSupportUser
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41328, 25)); // {"@type":"getSupportUser"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetWallpapers
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41360, 24)); // {"@type":"getWallpapers"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetLocalizationTargetInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41384, 36)); // {"@type":"getLocalizationTargetInfo"
            writer.WriteSpan(StringPool.Slice(34704, 14)); // ,"only_local":
            writer.WriteValue(this.only_local);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetLanguagePackStrings
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41424, 33)); // {"@type":"getLanguagePackStrings"
            writer.WriteSpan(StringPool.Slice(31968, 20)); // ,"language_pack_id":
            writer.WriteValue(this.language_pack_id);
            if (this.keys != null)
            {
                writer.WriteSpan(StringPool.Slice(41464, 8)); // ,"keys":
                writer.WriteArray(this.keys);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetCustomLanguagePack
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41472, 32)); // {"@type":"setCustomLanguagePack"
            if (this.info != null)
            {
                writer.WriteSpan(StringPool.Slice(28960, 8)); // ,"info":
                writer.WriteValue(this.info);
            }
            if (this.strings != null)
            {
                writer.WriteSpan(StringPool.Slice(24960, 11)); // ,"strings":
                writer.WriteArray(this.strings);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class EditCustomLanguagePackInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41504, 37)); // {"@type":"editCustomLanguagePackInfo"
            if (this.info != null)
            {
                writer.WriteSpan(StringPool.Slice(28960, 8)); // ,"info":
                writer.WriteValue(this.info);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetCustomLanguagePackString
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41544, 38)); // {"@type":"setCustomLanguagePackString"
            writer.WriteSpan(StringPool.Slice(31968, 20)); // ,"language_pack_id":
            writer.WriteValue(this.language_pack_id);
            if (this.new_string != null)
            {
                writer.WriteSpan(StringPool.Slice(41584, 14)); // ,"new_string":
                writer.WriteValue(this.new_string);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeleteLanguagePack
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41600, 29)); // {"@type":"deleteLanguagePack"
            writer.WriteSpan(StringPool.Slice(31968, 20)); // ,"language_pack_id":
            writer.WriteValue(this.language_pack_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RegisterDevice
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41632, 25)); // {"@type":"registerDevice"
            if (this.device_token != null)
            {
                writer.WriteSpan(StringPool.Slice(25208, 16)); // ,"device_token":
                writer.WriteValue(this.device_token);
            }
            if (this.other_user_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(41664, 18)); // ,"other_user_ids":
                writer.WriteArray(this.other_user_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetRecentlyVisitedTMeUrls
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41688, 36)); // {"@type":"getRecentlyVisitedTMeUrls"
            writer.WriteSpan(StringPool.Slice(41728, 12)); // ,"referrer":
            writer.WriteValue(this.referrer);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetUserPrivacySettingRules
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41744, 37)); // {"@type":"setUserPrivacySettingRules"
            if (this.setting != null)
            {
                writer.WriteSpan(StringPool.Slice(31416, 11)); // ,"setting":
                writer.WriteValue(this.setting);
            }
            if (this.rules != null)
            {
                writer.WriteSpan(StringPool.Slice(26544, 9)); // ,"rules":
                writer.WriteValue(this.rules);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetUserPrivacySettingRules
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41784, 37)); // {"@type":"getUserPrivacySettingRules"
            if (this.setting != null)
            {
                writer.WriteSpan(StringPool.Slice(31416, 11)); // ,"setting":
                writer.WriteValue(this.setting);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetOption
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41824, 20)); // {"@type":"getOption"
            writer.WriteSpan(StringPool.Slice(9624, 8)); // ,"name":
            writer.WriteValue(this.name);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetOption
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41848, 20)); // {"@type":"setOption"
            writer.WriteSpan(StringPool.Slice(9624, 8)); // ,"name":
            writer.WriteValue(this.name);
            if (this.value != null)
            {
                writer.WriteSpan(StringPool.Slice(15256, 9)); // ,"value":
                writer.WriteValue(this.value);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetAccountTtl
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41872, 24)); // {"@type":"setAccountTtl"
            if (this.ttl != null)
            {
                writer.WriteSpan(StringPool.Slice(6360, 7)); // ,"ttl":
                writer.WriteValue(this.ttl);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetAccountTtl
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41896, 24)); // {"@type":"getAccountTtl"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeleteAccount
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41920, 24)); // {"@type":"deleteAccount"
            writer.WriteSpan(StringPool.Slice(21256, 10)); // ,"reason":
            writer.WriteValue(this.reason);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetChatReportSpamState
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41944, 33)); // {"@type":"getChatReportSpamState"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ChangeChatReportSpamState
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(41984, 36)); // {"@type":"changeChatReportSpamState"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            writer.WriteSpan(StringPool.Slice(42024, 16)); // ,"is_spam_chat":
            writer.WriteValue(this.is_spam_chat);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ReportChat
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42040, 21)); // {"@type":"reportChat"
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            if (this.reason != null)
            {
                writer.WriteSpan(StringPool.Slice(21256, 10)); // ,"reason":
                writer.WriteValue(this.reason);
            }
            if (this.message_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(30672, 15)); // ,"message_ids":
                writer.WriteArray(this.message_ids);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetStorageStatistics
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42064, 31)); // {"@type":"getStorageStatistics"
            writer.WriteSpan(StringPool.Slice(42096, 14)); // ,"chat_limit":
            writer.WriteValue(this.chat_limit);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetStorageStatisticsFast
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42112, 35)); // {"@type":"getStorageStatisticsFast"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class OptimizeStorage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42152, 26)); // {"@type":"optimizeStorage"
            writer.WriteSpan(StringPool.Slice(2136, 8)); // ,"size":
            writer.WriteValue(this.size);
            writer.WriteSpan(StringPool.Slice(6360, 7)); // ,"ttl":
            writer.WriteValue(this.ttl);
            writer.WriteSpan(StringPool.Slice(27872, 9)); // ,"count":
            writer.WriteValue(this.count);
            writer.WriteSpan(StringPool.Slice(42184, 18)); // ,"immunity_delay":
            writer.WriteValue(this.immunity_delay);
            if (this.file_types != null)
            {
                writer.WriteSpan(StringPool.Slice(42208, 14)); // ,"file_types":
                writer.WriteArray(this.file_types);
            }
            if (this.chat_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(8104, 12)); // ,"chat_ids":
                writer.WriteArray(this.chat_ids);
            }
            if (this.exclude_chat_ids != null)
            {
                writer.WriteSpan(StringPool.Slice(42224, 20)); // ,"exclude_chat_ids":
                writer.WriteArray(this.exclude_chat_ids);
            }
            writer.WriteSpan(StringPool.Slice(42096, 14)); // ,"chat_limit":
            writer.WriteValue(this.chat_limit);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetNetworkType
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42248, 25)); // {"@type":"setNetworkType"
            if (this.type != null)
            {
                writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
                writer.WriteValue(this.type);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetNetworkStatistics
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42280, 31)); // {"@type":"getNetworkStatistics"
            writer.WriteSpan(StringPool.Slice(42312, 16)); // ,"only_current":
            writer.WriteValue(this.only_current);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AddNetworkStatistics
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42328, 31)); // {"@type":"addNetworkStatistics"
            if (this.entry != null)
            {
                writer.WriteSpan(StringPool.Slice(42360, 9)); // ,"entry":
                writer.WriteValue(this.entry);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ResetNetworkStatistics
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42376, 33)); // {"@type":"resetNetworkStatistics"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetPassportElement
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42416, 29)); // {"@type":"getPassportElement"
            if (this.type != null)
            {
                writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
                writer.WriteValue(this.type);
            }
            writer.WriteSpan(StringPool.Slice(29280, 12)); // ,"password":
            writer.WriteValue(this.password);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetAllPassportElements
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42448, 33)); // {"@type":"getAllPassportElements"
            writer.WriteSpan(StringPool.Slice(29280, 12)); // ,"password":
            writer.WriteValue(this.password);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetPassportElement
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42488, 29)); // {"@type":"setPassportElement"
            if (this.element != null)
            {
                writer.WriteSpan(StringPool.Slice(42520, 11)); // ,"element":
                writer.WriteValue(this.element);
            }
            writer.WriteSpan(StringPool.Slice(29280, 12)); // ,"password":
            writer.WriteValue(this.password);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DeletePassportElement
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42536, 32)); // {"@type":"deletePassportElement"
            if (this.type != null)
            {
                writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
                writer.WriteValue(this.type);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetPassportElementErrors
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42568, 35)); // {"@type":"setPassportElementErrors"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            if (this.errors != null)
            {
                writer.WriteSpan(StringPool.Slice(15120, 10)); // ,"errors":
                writer.WriteArray(this.errors);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetPreferredCountryLanguage
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42608, 38)); // {"@type":"getPreferredCountryLanguage"
            writer.WriteSpan(StringPool.Slice(10496, 16)); // ,"country_code":
            writer.WriteValue(this.country_code);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SendPhoneNumberVerificationCode
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42648, 42)); // {"@type":"sendPhoneNumberVerificationCode"
            writer.WriteSpan(StringPool.Slice(696, 16)); // ,"phone_number":
            writer.WriteValue(this.phone_number);
            writer.WriteSpan(StringPool.Slice(32840, 20)); // ,"allow_flash_call":
            writer.WriteValue(this.allow_flash_call);
            writer.WriteSpan(StringPool.Slice(32864, 27)); // ,"is_current_phone_number":
            writer.WriteValue(this.is_current_phone_number);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ResendPhoneNumberVerificationCode
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42696, 44)); // {"@type":"resendPhoneNumberVerificationCode"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CheckPhoneNumberVerificationCode
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42744, 43)); // {"@type":"checkPhoneNumberVerificationCode"
            writer.WriteSpan(StringPool.Slice(32, 8)); // ,"code":
            writer.WriteValue(this.code);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SendEmailAddressVerificationCode
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42792, 43)); // {"@type":"sendEmailAddressVerificationCode"
            writer.WriteSpan(StringPool.Slice(9128, 17)); // ,"email_address":
            writer.WriteValue(this.email_address);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ResendEmailAddressVerificationCode
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42840, 45)); // {"@type":"resendEmailAddressVerificationCode"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CheckEmailAddressVerificationCode
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42888, 44)); // {"@type":"checkEmailAddressVerificationCode"
            writer.WriteSpan(StringPool.Slice(32, 8)); // ,"code":
            writer.WriteValue(this.code);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetPassportAuthorizationForm
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(42936, 39)); // {"@type":"getPassportAuthorizationForm"
            writer.WriteSpan(StringPool.Slice(18656, 15)); // ,"bot_user_id":
            writer.WriteValue(this.bot_user_id);
            writer.WriteSpan(StringPool.Slice(30552, 9)); // ,"scope":
            writer.WriteValue(this.scope);
            writer.WriteSpan(StringPool.Slice(42976, 14)); // ,"public_key":
            writer.WriteValue(this.public_key);
            writer.WriteSpan(StringPool.Slice(42992, 9)); // ,"nonce":
            writer.WriteValue(this.nonce);
            writer.WriteSpan(StringPool.Slice(29280, 12)); // ,"password":
            writer.WriteValue(this.password);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SendPassportAuthorizationForm
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43008, 40)); // {"@type":"sendPassportAuthorizationForm"
            writer.WriteSpan(StringPool.Slice(43048, 24)); // ,"autorization_form_id":
            writer.WriteValue(this.autorization_form_id);
            if (this.types != null)
            {
                writer.WriteSpan(StringPool.Slice(17544, 9)); // ,"types":
                writer.WriteArray(this.types);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SendPhoneNumberConfirmationCode
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43072, 42)); // {"@type":"sendPhoneNumberConfirmationCode"
            writer.WriteSpan(StringPool.Slice(15192, 8)); // ,"hash":
            writer.WriteValue(this.hash);
            writer.WriteSpan(StringPool.Slice(696, 16)); // ,"phone_number":
            writer.WriteValue(this.phone_number);
            writer.WriteSpan(StringPool.Slice(32840, 20)); // ,"allow_flash_call":
            writer.WriteValue(this.allow_flash_call);
            writer.WriteSpan(StringPool.Slice(32864, 27)); // ,"is_current_phone_number":
            writer.WriteValue(this.is_current_phone_number);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class ResendPhoneNumberConfirmationCode
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43120, 44)); // {"@type":"resendPhoneNumberConfirmationCode"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CheckPhoneNumberConfirmationCode
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43168, 43)); // {"@type":"checkPhoneNumberConfirmationCode"
            writer.WriteSpan(StringPool.Slice(32, 8)); // ,"code":
            writer.WriteValue(this.code);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetBotUpdatesStatus
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43216, 30)); // {"@type":"setBotUpdatesStatus"
            writer.WriteSpan(StringPool.Slice(43248, 24)); // ,"pending_update_count":
            writer.WriteValue(this.pending_update_count);
            writer.WriteSpan(StringPool.Slice(29824, 17)); // ,"error_message":
            writer.WriteValue(this.error_message);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class UploadStickerFile
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43272, 28)); // {"@type":"uploadStickerFile"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            if (this.png_sticker != null)
            {
                writer.WriteSpan(StringPool.Slice(29504, 15)); // ,"png_sticker":
                writer.WriteValue(this.png_sticker);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class CreateNewStickerSet
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43304, 30)); // {"@type":"createNewStickerSet"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            writer.WriteSpan(StringPool.Slice(2752, 9)); // ,"title":
            writer.WriteValue(this.title);
            writer.WriteSpan(StringPool.Slice(9624, 8)); // ,"name":
            writer.WriteValue(this.name);
            writer.WriteSpan(StringPool.Slice(20496, 12)); // ,"is_masks":
            writer.WriteValue(this.is_masks);
            if (this.stickers != null)
            {
                writer.WriteSpan(StringPool.Slice(20368, 12)); // ,"stickers":
                writer.WriteArray(this.stickers);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AddStickerToSet
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43336, 26)); // {"@type":"addStickerToSet"
            writer.WriteSpan(StringPool.Slice(3240, 11)); // ,"user_id":
            writer.WriteValue(this.user_id);
            writer.WriteSpan(StringPool.Slice(9624, 8)); // ,"name":
            writer.WriteValue(this.name);
            if (this.sticker != null)
            {
                writer.WriteSpan(StringPool.Slice(3016, 11)); // ,"sticker":
                writer.WriteValue(this.sticker);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetStickerPositionInSet
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43368, 34)); // {"@type":"setStickerPositionInSet"
            if (this.sticker != null)
            {
                writer.WriteSpan(StringPool.Slice(3016, 11)); // ,"sticker":
                writer.WriteValue(this.sticker);
            }
            writer.WriteSpan(StringPool.Slice(23344, 12)); // ,"position":
            writer.WriteValue(this.position);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RemoveStickerFromSet
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43408, 31)); // {"@type":"removeStickerFromSet"
            if (this.sticker != null)
            {
                writer.WriteSpan(StringPool.Slice(3016, 11)); // ,"sticker":
                writer.WriteValue(this.sticker);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetMapThumbnailFile
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43440, 30)); // {"@type":"getMapThumbnailFile"
            if (this.location != null)
            {
                writer.WriteSpan(StringPool.Slice(3328, 12)); // ,"location":
                writer.WriteValue(this.location);
            }
            writer.WriteSpan(StringPool.Slice(43472, 8)); // ,"zoom":
            writer.WriteValue(this.zoom);
            writer.WriteSpan(StringPool.Slice(2400, 9)); // ,"width":
            writer.WriteValue(this.width);
            writer.WriteSpan(StringPool.Slice(2416, 10)); // ,"height":
            writer.WriteValue(this.height);
            writer.WriteSpan(StringPool.Slice(2616, 9)); // ,"scale":
            writer.WriteValue(this.scale);
            writer.WriteSpan(StringPool.Slice(6560, 11)); // ,"chat_id":
            writer.WriteValue(this.chat_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AcceptTermsOfService
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43480, 31)); // {"@type":"acceptTermsOfService"
            writer.WriteSpan(StringPool.Slice(32056, 23)); // ,"terms_of_service_id":
            writer.WriteValue(this.terms_of_service_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SendCustomRequest
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43512, 28)); // {"@type":"sendCustomRequest"
            writer.WriteSpan(StringPool.Slice(43544, 10)); // ,"method":
            writer.WriteValue(this.method);
            writer.WriteSpan(StringPool.Slice(32744, 14)); // ,"parameters":
            writer.WriteValue(this.parameters);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AnswerCustomQuery
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43560, 28)); // {"@type":"answerCustomQuery"
            writer.WriteSpan(StringPool.Slice(43592, 19)); // ,"custom_query_id":
            writer.WriteInt64String(this.custom_query_id);
            writer.WriteSpan(StringPool.Slice(8488, 8)); // ,"data":
            writer.WriteValue(this.data);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class SetAlarm
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43616, 19)); // {"@type":"setAlarm"
            writer.WriteSpan(StringPool.Slice(29112, 11)); // ,"seconds":
            writer.WriteValue(this.seconds);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetCountryCode
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43640, 25)); // {"@type":"getCountryCode"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetInviteText
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43672, 24)); // {"@type":"getInviteText"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetDeepLinkInfo
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43696, 26)); // {"@type":"getDeepLinkInfo"
            writer.WriteSpan(StringPool.Slice(27320, 8)); // ,"link":
            writer.WriteValue(this.link);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class AddProxy
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43728, 19)); // {"@type":"addProxy"
            writer.WriteSpan(StringPool.Slice(29384, 10)); // ,"server":
            writer.WriteValue(this.server);
            writer.WriteSpan(StringPool.Slice(20936, 8)); // ,"port":
            writer.WriteValue(this.port);
            writer.WriteSpan(StringPool.Slice(43752, 10)); // ,"enable":
            writer.WriteValue(this.enable);
            if (this.type != null)
            {
                writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
                writer.WriteValue(this.type);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class EditProxy
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43768, 20)); // {"@type":"editProxy"
            writer.WriteSpan(StringPool.Slice(43792, 12)); // ,"proxy_id":
            writer.WriteValue(this.proxy_id);
            writer.WriteSpan(StringPool.Slice(29384, 10)); // ,"server":
            writer.WriteValue(this.server);
            writer.WriteSpan(StringPool.Slice(20936, 8)); // ,"port":
            writer.WriteValue(this.port);
            writer.WriteSpan(StringPool.Slice(43752, 10)); // ,"enable":
            writer.WriteValue(this.enable);
            if (this.type != null)
            {
                writer.WriteSpan(StringPool.Slice(712, 8)); // ,"type":
                writer.WriteValue(this.type);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class EnableProxy
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43808, 22)); // {"@type":"enableProxy"
            writer.WriteSpan(StringPool.Slice(43792, 12)); // ,"proxy_id":
            writer.WriteValue(this.proxy_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class DisableProxy
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43832, 23)); // {"@type":"disableProxy"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class RemoveProxy
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43856, 22)); // {"@type":"removeProxy"
            writer.WriteSpan(StringPool.Slice(43792, 12)); // ,"proxy_id":
            writer.WriteValue(this.proxy_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetProxies
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43880, 21)); // {"@type":"getProxies"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class GetProxyLink
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43904, 23)); // {"@type":"getProxyLink"
            writer.WriteSpan(StringPool.Slice(43792, 12)); // ,"proxy_id":
            writer.WriteValue(this.proxy_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class PingProxy
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43928, 20)); // {"@type":"pingProxy"
            writer.WriteSpan(StringPool.Slice(43792, 12)); // ,"proxy_id":
            writer.WriteValue(this.proxy_id);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TestCallEmpty
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43952, 24)); // {"@type":"testCallEmpty"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TestCallString
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(43976, 25)); // {"@type":"testCallString"
            writer.WriteSpan(StringPool.Slice(44008, 5)); // ,"x":
            writer.WriteValue(this.x);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TestCallBytes
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(44016, 24)); // {"@type":"testCallBytes"
            if (this.x != null)
            {
                writer.WriteSpan(StringPool.Slice(44008, 5)); // ,"x":
                writer.WriteBytesValue(this.x);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TestCallVectorInt
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(44040, 28)); // {"@type":"testCallVectorInt"
            if (this.x != null)
            {
                writer.WriteSpan(StringPool.Slice(44008, 5)); // ,"x":
                writer.WriteArray(this.x);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TestCallVectorIntObject
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(44072, 34)); // {"@type":"testCallVectorIntObject"
            if (this.x != null)
            {
                writer.WriteSpan(StringPool.Slice(44008, 5)); // ,"x":
                writer.WriteArray(this.x);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TestCallVectorString
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(44112, 31)); // {"@type":"testCallVectorString"
            if (this.x != null)
            {
                writer.WriteSpan(StringPool.Slice(44008, 5)); // ,"x":
                writer.WriteArray(this.x);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TestCallVectorStringObject
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(44144, 37)); // {"@type":"testCallVectorStringObject"
            if (this.x != null)
            {
                writer.WriteSpan(StringPool.Slice(44008, 5)); // ,"x":
                writer.WriteArray(this.x);
            }
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TestSquareInt
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(44184, 24)); // {"@type":"testSquareInt"
            writer.WriteSpan(StringPool.Slice(44008, 5)); // ,"x":
            writer.WriteValue(this.x);
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TestNetwork
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(44208, 22)); // {"@type":"testNetwork"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TestGetDifference
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(44232, 28)); // {"@type":"testGetDifference"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TestUseUpdate
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(44264, 24)); // {"@type":"testUseUpdate"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    public partial class TestUseError
    {
        internal override void TdJsonWrite(TdJsonWriter writer)
        {
            writer.WriteSpan(StringPool.Slice(44288, 23)); // {"@type":"testUseError"
            TdJsonWriteExtra(writer);
            writer.WriteEndObject();
        }
    }

    internal partial class StringPool
    {
        private const uint _poolcrc = 0x1131B414u;
    }

}
