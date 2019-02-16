using System;
using Newtonsoft.Json;

//////////////////////////////////////
//// GENERATED FILE! DO NOT EDIT! ////
//////////////////////////////////////

namespace TDLib.Api.Types
{
    [TLTypeHash(0x5DDDBC71u)]
    public partial class Error
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x77153098u:
                    this.code = reader.ReadInt();
                    return true;
                case 0xB6BD307Fu:
                    this.message = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x79DCDD47u)]
    public partial class Ok { }
    [TLTypeHash(0x4DCC8587u)]
    public partial class TdlibParameters
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xCB85648Eu:
                    this.use_test_dc = reader.ReadBool();
                    return true;
                case 0xAB468153u:
                    this.database_directory = reader.ReadStringAsUTF16String();
                    return true;
                case 0x3E8A2361u:
                    this.files_directory = reader.ReadStringAsUTF16String();
                    return true;
                case 0xD80A9F9Bu:
                    this.use_file_database = reader.ReadBool();
                    return true;
                case 0x6132CE7Bu:
                    this.use_chat_info_database = reader.ReadBool();
                    return true;
                case 0x936FD8B4u:
                    this.use_message_database = reader.ReadBool();
                    return true;
                case 0x784DA406u:
                    this.use_secret_chats = reader.ReadBool();
                    return true;
                case 0x54963938u:
                    this.api_id = reader.ReadInt();
                    return true;
                case 0xF04F144Bu:
                    this.api_hash = reader.ReadStringAsUTF16String();
                    return true;
                case 0x3BBE9541u:
                    this.system_language_code = reader.ReadStringAsUTF16String();
                    return true;
                case 0x111092BEu:
                    this.device_model = reader.ReadStringAsUTF16String();
                    return true;
                case 0x536FAF50u:
                    this.system_version = reader.ReadStringAsUTF16String();
                    return true;
                case 0x54A2D6F0u:
                    this.application_version = reader.ReadStringAsUTF16String();
                    return true;
                case 0x670519C1u:
                    this.enable_storage_optimizer = reader.ReadBool();
                    return true;
                case 0x50255BE1u:
                    this.ignore_file_names = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF0AF66CEu)]
    public partial class AuthenticationCodeTypeTelegramMessage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x017D9EB2u:
                    this.length = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDDE9A4B7u)]
    public partial class AuthenticationCodeTypeSms
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x017D9EB2u:
                    this.length = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5787AD10u)]
    public partial class AuthenticationCodeTypeCall
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x017D9EB2u:
                    this.length = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xAE3C8551u)]
    public partial class AuthenticationCodeTypeFlashCall
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA3BCFC8Eu:
                    this.pattern = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7C32B6F3u)]
    public partial class AuthenticationCodeInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x6B01BC5Bu:
                    this.phone_number = reader.ReadStringAsUTF16String();
                    return true;
                case 0x8CDE5729u:
                    this.type = (AuthenticationCodeType)reader.ReadValue();
                    return true;
                case 0xB24EE1F3u:
                    this.next_type = (AuthenticationCodeType)reader.ReadValue();
                    return true;
                case 0x81417592u:
                    this.timeout = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA8DCCCD6u)]
    public partial class EmailAddressAuthenticationCodeInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A398E1Eu:
                    this.email_address_pattern = reader.ReadStringAsUTF16String();
                    return true;
                case 0x017D9EB2u:
                    this.length = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD508179Fu)]
    public partial class TextEntity
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x590ACAD0u:
                    this.offset = reader.ReadInt();
                    return true;
                case 0x017D9EB2u:
                    this.length = reader.ReadInt();
                    return true;
                case 0x8CDE5729u:
                    this.type = (TextEntityType)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF973C8F1u)]
    public partial class TextEntities
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x50EC64E5u:
                    this.entities = reader.ReadArray<TextEntity>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8CA0B2BEu)]
    public partial class FormattedText
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = reader.ReadStringAsUTF16String();
                    return true;
                case 0x50EC64E5u:
                    this.entities = reader.ReadArray<TextEntity>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDB08CFC1u)]
    public partial class TermsOfService
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = (FormattedText)reader.ReadValue();
                    return true;
                case 0xAB701700u:
                    this.min_user_age = reader.ReadInt();
                    return true;
                case 0x08B80084u:
                    this.show_popup = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8A974939u)]
    public partial class AuthorizationStateWaitTdlibParameters { }
    [TLTypeHash(0x1BBCA758u)]
    public partial class AuthorizationStateWaitEncryptionKey
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x50802D1Cu:
                    this.is_encrypted = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5D887154u)]
    public partial class AuthorizationStateWaitPhoneNumber { }
    [TLTypeHash(0xA10BC512u)]
    public partial class AuthorizationStateWaitCode
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x96F465C4u:
                    this.is_registered = reader.ReadBool();
                    return true;
                case 0x937BFB98u:
                    this.terms_of_service = (TermsOfService)reader.ReadValue();
                    return true;
                case 0xFD625B96u:
                    this.code_info = (AuthenticationCodeInfo)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBFD8E98Fu)]
    public partial class AuthorizationStateWaitPassword
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA6930418u:
                    this.password_hint = reader.ReadStringAsUTF16String();
                    return true;
                case 0xB7950DA4u:
                    this.has_recovery_email_address = reader.ReadBool();
                    return true;
                case 0xBE6EB4C4u:
                    this.recovery_email_address_pattern = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4ED0A2C7u)]
    public partial class AuthorizationStateReady { }
    [TLTypeHash(0x3F0B9B5Au)]
    public partial class AuthorizationStateLoggingOut { }
    [TLTypeHash(0x5D6CD935u)]
    public partial class AuthorizationStateClosing { }
    [TLTypeHash(0x47C8E1A9u)]
    public partial class AuthorizationStateClosed { }
    [TLTypeHash(0xAD228AAFu)]
    public partial class PasswordState
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x24A4BCE1u:
                    this.has_password = reader.ReadBool();
                    return true;
                case 0xA6930418u:
                    this.password_hint = reader.ReadStringAsUTF16String();
                    return true;
                case 0xB7950DA4u:
                    this.has_recovery_email_address = reader.ReadBool();
                    return true;
                case 0xFAE8E77Du:
                    this.has_passport_data = reader.ReadBool();
                    return true;
                case 0x5AFEC57Du:
                    this.unconfirmed_recovery_email_address_pattern = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x09658FBEu)]
    public partial class RecoveryEmailAddress
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8D392B5Du:
                    this.recovery_email_address = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDDE1EF55u)]
    public partial class TemporaryPasswordState
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x24A4BCE1u:
                    this.has_password = reader.ReadBool();
                    return true;
                case 0xF5F46844u:
                    this.valid_for = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7D4882F0u)]
    public partial class LocalFile
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x0B548B0Fu:
                    this.path = reader.ReadStringAsUTF16String();
                    return true;
                case 0x49FC3DF9u:
                    this.can_be_downloaded = reader.ReadBool();
                    return true;
                case 0xE1F0269Bu:
                    this.can_be_deleted = reader.ReadBool();
                    return true;
                case 0xA100D140u:
                    this.is_downloading_active = reader.ReadBool();
                    return true;
                case 0x93C362A6u:
                    this.is_downloading_completed = reader.ReadBool();
                    return true;
                case 0x48813773u:
                    this.downloaded_prefix_size = reader.ReadInt();
                    return true;
                case 0x808B30B4u:
                    this.downloaded_size = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xFD5A8186u)]
    public partial class RemoteFile
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0xF3B23038u:
                    this.is_uploading_active = reader.ReadBool();
                    return true;
                case 0xAB2B4B11u:
                    this.is_uploading_completed = reader.ReadBool();
                    return true;
                case 0xCF52E527u:
                    this.uploaded_size = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8C9F3610u)]
    public partial class File
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadInt();
                    return true;
                case 0xF7C0246Au:
                    this.size = reader.ReadInt();
                    return true;
                case 0x9CDAEA6Bu:
                    this.expected_size = reader.ReadInt();
                    return true;
                case 0x8BD688E8u:
                    this.local = (LocalFile)reader.ReadValue();
                    return true;
                case 0x5AB67FB2u:
                    this.remote = (RemoteFile)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9AAF69BBu)]
    public partial class InputFileId
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3D496D5Au)]
    public partial class InputFileRemote
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA98EAC73u)]
    public partial class InputFileLocal
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x0B548B0Fu:
                    this.path = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3692388Au)]
    public partial class InputFileGenerated
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x0121E039u:
                    this.original_path = reader.ReadStringAsUTF16String();
                    return true;
                case 0xBD912744u:
                    this.conversion = reader.ReadStringAsUTF16String();
                    return true;
                case 0x9CDAEA6Bu:
                    this.expected_size = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x953DAB7Au)]
    public partial class PhotoSize
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8CDE5729u:
                    this.type = reader.ReadStringAsUTF16String();
                    return true;
                case 0x14B78418u:
                    this.photo = (File)reader.ReadValue();
                    return true;
                case 0x8C1A452Fu:
                    this.width = reader.ReadInt();
                    return true;
                case 0xF54DE50Fu:
                    this.height = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF26E5D18u)]
    public partial class MaskPointForehead { }
    [TLTypeHash(0xC6EC8176u)]
    public partial class MaskPointEyes { }
    [TLTypeHash(0x3EAE485Au)]
    public partial class MaskPointMouth { }
    [TLTypeHash(0x31D03438u)]
    public partial class MaskPointChin { }
    [TLTypeHash(0x45429A59u)]
    public partial class MaskPosition
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xB7A5F324u:
                    this.point = (MaskPoint)reader.ReadValue();
                    return true;
                case 0xDC1A3748u:
                    this.x_shift = reader.ReadDouble();
                    return true;
                case 0x7A6D3CFCu:
                    this.y_shift = reader.ReadDouble();
                    return true;
                case 0xEC462584u:
                    this.scale = reader.ReadDouble();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8D5284DCu)]
    public partial class Animation
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x865F80C0u:
                    this.duration = reader.ReadInt();
                    return true;
                case 0x8C1A452Fu:
                    this.width = reader.ReadInt();
                    return true;
                case 0xF54DE50Fu:
                    this.height = reader.ReadInt();
                    return true;
                case 0xD7DF1668u:
                    this.file_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2100AA2Eu:
                    this.mime_type = reader.ReadStringAsUTF16String();
                    return true;
                case 0xC35726E6u:
                    this.thumbnail = (PhotoSize)reader.ReadValue();
                    return true;
                case 0x8D5284DCu:
                    this.animation = (File)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x187D3695u)]
    public partial class Audio
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x865F80C0u:
                    this.duration = reader.ReadInt();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x17210BEBu:
                    this.performer = reader.ReadStringAsUTF16String();
                    return true;
                case 0xD7DF1668u:
                    this.file_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2100AA2Eu:
                    this.mime_type = reader.ReadStringAsUTF16String();
                    return true;
                case 0xBC627951u:
                    this.album_cover_thumbnail = (PhotoSize)reader.ReadValue();
                    return true;
                case 0x187D3695u:
                    this.audio = (File)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD8698A76u)]
    public partial class Document
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xD7DF1668u:
                    this.file_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2100AA2Eu:
                    this.mime_type = reader.ReadStringAsUTF16String();
                    return true;
                case 0xC35726E6u:
                    this.thumbnail = (PhotoSize)reader.ReadValue();
                    return true;
                case 0xD8698A76u:
                    this.document = (File)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x14B78418u)]
    public partial class Photo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadIntegerString();
                    return true;
                case 0xC9EB5622u:
                    this.has_stickers = reader.ReadBool();
                    return true;
                case 0xB69E8769u:
                    this.sizes = reader.ReadArray<PhotoSize>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8FEDBCFDu)]
    public partial class Sticker
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x10FB0D18u:
                    this.set_id = reader.ReadIntegerString();
                    return true;
                case 0x8C1A452Fu:
                    this.width = reader.ReadInt();
                    return true;
                case 0xF54DE50Fu:
                    this.height = reader.ReadInt();
                    return true;
                case 0xB64BF632u:
                    this.emoji = reader.ReadStringAsUTF16String();
                    return true;
                case 0xEA9CED11u:
                    this.is_mask = reader.ReadBool();
                    return true;
                case 0x357EA28Bu:
                    this.mask_position = (MaskPosition)reader.ReadValue();
                    return true;
                case 0xC35726E6u:
                    this.thumbnail = (PhotoSize)reader.ReadValue();
                    return true;
                case 0x8FEDBCFDu:
                    this.sticker = (File)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7CC7DA2Cu)]
    public partial class Video
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x865F80C0u:
                    this.duration = reader.ReadInt();
                    return true;
                case 0x8C1A452Fu:
                    this.width = reader.ReadInt();
                    return true;
                case 0xF54DE50Fu:
                    this.height = reader.ReadInt();
                    return true;
                case 0xD7DF1668u:
                    this.file_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2100AA2Eu:
                    this.mime_type = reader.ReadStringAsUTF16String();
                    return true;
                case 0xC9EB5622u:
                    this.has_stickers = reader.ReadBool();
                    return true;
                case 0xC5ED604Eu:
                    this.supports_streaming = reader.ReadBool();
                    return true;
                case 0xC35726E6u:
                    this.thumbnail = (PhotoSize)reader.ReadValue();
                    return true;
                case 0x7CC7DA2Cu:
                    this.video = (File)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD87D89D4u)]
    public partial class VideoNote
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x865F80C0u:
                    this.duration = reader.ReadInt();
                    return true;
                case 0x017D9EB2u:
                    this.length = reader.ReadInt();
                    return true;
                case 0xC35726E6u:
                    this.thumbnail = (PhotoSize)reader.ReadValue();
                    return true;
                case 0x7CC7DA2Cu:
                    this.video = (File)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE32C1A2Fu)]
    public partial class VoiceNote
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x865F80C0u:
                    this.duration = reader.ReadInt();
                    return true;
                case 0x11133403u:
                    this.waveform = reader.ReadBase64String();
                    return true;
                case 0x2100AA2Eu:
                    this.mime_type = reader.ReadStringAsUTF16String();
                    return true;
                case 0xE7FB583Bu:
                    this.voice = (File)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4C62E638u)]
    public partial class Contact
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x6B01BC5Bu:
                    this.phone_number = reader.ReadStringAsUTF16String();
                    return true;
                case 0xA9D1C132u:
                    this.first_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0xC808BA5Au:
                    this.last_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x87E0A5BDu:
                    this.vcard = reader.ReadStringAsUTF16String();
                    return true;
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5E9E89CBu)]
    public partial class Location
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x4118D123u:
                    this.latitude = reader.ReadDouble();
                    return true;
                case 0x85E16F6Bu:
                    this.longitude = reader.ReadDouble();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x91911B0Du)]
    public partial class Venue
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5E9E89CBu:
                    this.location = (Location)reader.ReadValue();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x0D4E6F81u:
                    this.address = reader.ReadStringAsUTF16String();
                    return true;
                case 0x92C4739Cu:
                    this.provider = reader.ReadStringAsUTF16String();
                    return true;
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x8CDE5729u:
                    this.type = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x232B318Cu)]
    public partial class Game
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadIntegerString();
                    return true;
                case 0x3EE4B093u:
                    this.short_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x3B8BA7C7u:
                    this.text = (FormattedText)reader.ReadValue();
                    return true;
                case 0x6DE44026u:
                    this.description = reader.ReadStringAsUTF16String();
                    return true;
                case 0x14B78418u:
                    this.photo = (Photo)reader.ReadValue();
                    return true;
                case 0x8D5284DCu:
                    this.animation = (Animation)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3E9B5493u)]
    public partial class ProfilePhoto
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadIntegerString();
                    return true;
                case 0x7545EA13u:
                    this.small = (File)reader.ReadValue();
                    return true;
                case 0xD3FBE249u:
                    this.big = (File)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2ECF4646u)]
    public partial class ChatPhoto
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x7545EA13u:
                    this.small = (File)reader.ReadValue();
                    return true;
                case 0xD3FBE249u:
                    this.big = (File)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x74E05388u)]
    public partial class LinkStateNone { }
    [TLTypeHash(0xBA88E13Eu)]
    public partial class LinkStateKnowsPhoneNumber { }
    [TLTypeHash(0xAECB2076u)]
    public partial class LinkStateIsContact { }
    [TLTypeHash(0x1D980FB0u)]
    public partial class UserTypeRegular { }
    [TLTypeHash(0xBCD24257u)]
    public partial class UserTypeDeleted { }
    [TLTypeHash(0xC983CE70u)]
    public partial class UserTypeBot
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1CBC440Bu:
                    this.can_join_groups = reader.ReadBool();
                    return true;
                case 0x2604F349u:
                    this.can_read_all_group_messages = reader.ReadBool();
                    return true;
                case 0x1822D028u:
                    this.is_inline = reader.ReadBool();
                    return true;
                case 0x6C5C0BEBu:
                    this.inline_query_placeholder = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2448CD01u:
                    this.need_location = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xFACFABA3u)]
    public partial class UserTypeUnknown { }
    [TLTypeHash(0x41436112u)]
    public partial class BotCommand
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8ECAEAD4u:
                    this.command = reader.ReadStringAsUTF16String();
                    return true;
                case 0x6DE44026u:
                    this.description = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3E4A3847u)]
    public partial class BotInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x6DE44026u:
                    this.description = reader.ReadStringAsUTF16String();
                    return true;
                case 0x9A3E132Cu:
                    this.commands = reader.ReadArray<BotCommand>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8D93D649u)]
    public partial class User
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadInt();
                    return true;
                case 0xA9D1C132u:
                    this.first_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0xC808BA5Au:
                    this.last_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0xF85E0677u:
                    this.username = reader.ReadStringAsUTF16String();
                    return true;
                case 0x6B01BC5Bu:
                    this.phone_number = reader.ReadStringAsUTF16String();
                    return true;
                case 0x7B00651Cu:
                    this.status = (UserStatus)reader.ReadValue();
                    return true;
                case 0xE3631BCAu:
                    this.profile_photo = (ProfilePhoto)reader.ReadValue();
                    return true;
                case 0xC873623Du:
                    this.outgoing_link = (LinkState)reader.ReadValue();
                    return true;
                case 0xAFF04D28u:
                    this.incoming_link = (LinkState)reader.ReadValue();
                    return true;
                case 0x9AEC891Du:
                    this.is_verified = reader.ReadBool();
                    return true;
                case 0xF19C6840u:
                    this.restriction_reason = reader.ReadStringAsUTF16String();
                    return true;
                case 0xC631AEF6u:
                    this.have_access = reader.ReadBool();
                    return true;
                case 0x8CDE5729u:
                    this.type = (UserType)reader.ReadValue();
                    return true;
                case 0x451CDAD4u:
                    this.language_code = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x71CE00E0u)]
    public partial class UserFullInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xCC696D48u:
                    this.is_blocked = reader.ReadBool();
                    return true;
                case 0x325E4D78u:
                    this.can_be_called = reader.ReadBool();
                    return true;
                case 0x54137C77u:
                    this.has_private_calls = reader.ReadBool();
                    return true;
                case 0xDD206A7Bu:
                    this.bio = reader.ReadStringAsUTF16String();
                    return true;
                case 0x864CAA5Eu:
                    this.share_text = reader.ReadStringAsUTF16String();
                    return true;
                case 0x4D044D98u:
                    this.group_in_common_count = reader.ReadInt();
                    return true;
                case 0x4A2FBD25u:
                    this.bot_info = (BotInfo)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1BDFC3FFu)]
    public partial class UserProfilePhotos
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x46ABD250u:
                    this.total_count = reader.ReadInt();
                    return true;
                case 0x0876E0D9u:
                    this.photos = reader.ReadArray<Photo>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1483A5E9u)]
    public partial class Users
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x46ABD250u:
                    this.total_count = reader.ReadInt();
                    return true;
                case 0x9BCCC613u:
                    this.user_ids = reader.ReadArray<int>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD2FC509Du)]
    public partial class ChatMemberStatusCreator
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x20AD77A7u:
                    this.is_member = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x86A27E64u)]
    public partial class ChatMemberStatusAdministrator
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x090C23EFu:
                    this.can_be_edited = reader.ReadBool();
                    return true;
                case 0xEC6198B1u:
                    this.can_change_info = reader.ReadBool();
                    return true;
                case 0xCBF01269u:
                    this.can_post_messages = reader.ReadBool();
                    return true;
                case 0x5F133FE1u:
                    this.can_edit_messages = reader.ReadBool();
                    return true;
                case 0xE043B3E9u:
                    this.can_delete_messages = reader.ReadBool();
                    return true;
                case 0x0C68E9BFu:
                    this.can_invite_users = reader.ReadBool();
                    return true;
                case 0xA4E4B2B2u:
                    this.can_restrict_members = reader.ReadBool();
                    return true;
                case 0xBD7D8614u:
                    this.can_pin_messages = reader.ReadBool();
                    return true;
                case 0x82AA0B58u:
                    this.can_promote_members = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE158E3EFu)]
    public partial class ChatMemberStatusMember { }
    [TLTypeHash(0x3BD483C3u)]
    public partial class ChatMemberStatusRestricted
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x20AD77A7u:
                    this.is_member = reader.ReadBool();
                    return true;
                case 0x4B7DDEFAu:
                    this.restricted_until_date = reader.ReadInt();
                    return true;
                case 0xDEC19EE2u:
                    this.can_send_messages = reader.ReadBool();
                    return true;
                case 0x97054C62u:
                    this.can_send_media_messages = reader.ReadBool();
                    return true;
                case 0xDC73123Du:
                    this.can_send_other_messages = reader.ReadBool();
                    return true;
                case 0x8842E484u:
                    this.can_add_web_page_previews = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x024C73C0u)]
    public partial class ChatMemberStatusLeft { }
    [TLTypeHash(0x0AF51421u)]
    public partial class ChatMemberStatusBanned
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3E80476Eu:
                    this.banned_until_date = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xFC0DFE49u)]
    public partial class ChatMember
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0x1A579695u:
                    this.inviter_user_id = reader.ReadInt();
                    return true;
                case 0x1389C1F5u:
                    this.joined_chat_date = reader.ReadInt();
                    return true;
                case 0x7B00651Cu:
                    this.status = (ChatMemberStatus)reader.ReadValue();
                    return true;
                case 0x4A2FBD25u:
                    this.bot_info = (BotInfo)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x14F23BC1u)]
    public partial class ChatMembers
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x46ABD250u:
                    this.total_count = reader.ReadInt();
                    return true;
                case 0x45A0D2FFu:
                    this.members = reader.ReadArray<ChatMember>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB3B91823u)]
    public partial class ChatMembersFilterAdministrators { }
    [TLTypeHash(0xB75B1967u)]
    public partial class ChatMembersFilterMembers { }
    [TLTypeHash(0x36AD4CECu)]
    public partial class ChatMembersFilterRestricted { }
    [TLTypeHash(0x0282DBE5u)]
    public partial class ChatMembersFilterBanned { }
    [TLTypeHash(0x21A95441u)]
    public partial class ChatMembersFilterBots { }
    [TLTypeHash(0x4DC061AAu)]
    public partial class SupergroupMembersFilterRecent { }
    [TLTypeHash(0x1097D5A5u)]
    public partial class SupergroupMembersFilterAdministrators { }
    [TLTypeHash(0x9453ED73u)]
    public partial class SupergroupMembersFilterSearch
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x24BDB5EBu:
                    this.query = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF058F849u)]
    public partial class SupergroupMembersFilterRestricted
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x24BDB5EBu:
                    this.query = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBBEA3B62u)]
    public partial class SupergroupMembersFilterBanned
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x24BDB5EBu:
                    this.query = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xCEAF1049u)]
    public partial class SupergroupMembersFilterBots { }
    [TLTypeHash(0xA53257B1u)]
    public partial class BasicGroup
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadInt();
                    return true;
                case 0xE7F8D191u:
                    this.member_count = reader.ReadInt();
                    return true;
                case 0x7B00651Cu:
                    this.status = (ChatMemberStatus)reader.ReadValue();
                    return true;
                case 0x96D4D2B3u:
                    this.everyone_is_administrator = reader.ReadBool();
                    return true;
                case 0x1B5771DDu:
                    this.is_active = reader.ReadBool();
                    return true;
                case 0x04E045E0u:
                    this.upgraded_to_supergroup_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x50D048D7u)]
    public partial class BasicGroupFullInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x29FC6AE1u:
                    this.creator_user_id = reader.ReadInt();
                    return true;
                case 0x45A0D2FFu:
                    this.members = reader.ReadArray<ChatMember>();
                    return true;
                case 0x2E98587Bu:
                    this.invite_link = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDC163DB7u)]
    public partial class Supergroup
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadInt();
                    return true;
                case 0xF85E0677u:
                    this.username = reader.ReadStringAsUTF16String();
                    return true;
                case 0xAA9E377Au:
                    this.date = reader.ReadInt();
                    return true;
                case 0x7B00651Cu:
                    this.status = (ChatMemberStatus)reader.ReadValue();
                    return true;
                case 0xE7F8D191u:
                    this.member_count = reader.ReadInt();
                    return true;
                case 0x36BEB4E3u:
                    this.anyone_can_invite = reader.ReadBool();
                    return true;
                case 0x18BBF871u:
                    this.sign_messages = reader.ReadBool();
                    return true;
                case 0xB4C5088Fu:
                    this.is_channel = reader.ReadBool();
                    return true;
                case 0x9AEC891Du:
                    this.is_verified = reader.ReadBool();
                    return true;
                case 0xF19C6840u:
                    this.restriction_reason = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD1869765u)]
    public partial class SupergroupFullInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x6DE44026u:
                    this.description = reader.ReadStringAsUTF16String();
                    return true;
                case 0xE7F8D191u:
                    this.member_count = reader.ReadInt();
                    return true;
                case 0x5BEB50CBu:
                    this.administrator_count = reader.ReadInt();
                    return true;
                case 0x0421F3C3u:
                    this.restricted_count = reader.ReadInt();
                    return true;
                case 0x2CB8DC81u:
                    this.banned_count = reader.ReadInt();
                    return true;
                case 0x981C630Cu:
                    this.can_get_members = reader.ReadBool();
                    return true;
                case 0xD329CFE3u:
                    this.can_set_username = reader.ReadBool();
                    return true;
                case 0xABA37EA7u:
                    this.can_set_sticker_set = reader.ReadBool();
                    return true;
                case 0xF4846EB9u:
                    this.is_all_history_available = reader.ReadBool();
                    return true;
                case 0xE417C78Fu:
                    this.sticker_set_id = reader.ReadIntegerString();
                    return true;
                case 0x2E98587Bu:
                    this.invite_link = reader.ReadStringAsUTF16String();
                    return true;
                case 0xC254572Fu:
                    this.pinned_message_id = reader.ReadLong();
                    return true;
                case 0xF73F873Du:
                    this.upgraded_from_basic_group_id = reader.ReadInt();
                    return true;
                case 0xAC5B5A3Fu:
                    this.upgraded_from_max_message_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x65C2874Du)]
    public partial class SecretChatStatePending { }
    [TLTypeHash(0x5024DCFEu)]
    public partial class SecretChatStateReady { }
    [TLTypeHash(0x18D39DDFu)]
    public partial class SecretChatStateClosed { }
    [TLTypeHash(0x7D13AE32u)]
    public partial class SecretChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadInt();
                    return true;
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0xA393D2FBu:
                    this.state = (SecretChatState)reader.ReadValue();
                    return true;
                case 0xB48F218Au:
                    this.is_outbound = reader.ReadBool();
                    return true;
                case 0xA3EE881Fu:
                    this.ttl = reader.ReadInt();
                    return true;
                case 0x57BFB971u:
                    this.key_hash = reader.ReadBase64String();
                    return true;
                case 0xE4DB211Au:
                    this.layer = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x95918461u)]
    public partial class MessageForwardedFromUser
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2A98155Eu:
                    this.sender_user_id = reader.ReadInt();
                    return true;
                case 0xAA9E377Au:
                    this.date = reader.ReadInt();
                    return true;
                case 0xF88B1654u:
                    this.forwarded_from_chat_id = reader.ReadLong();
                    return true;
                case 0x4645CC3Eu:
                    this.forwarded_from_message_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x51B8E126u)]
    public partial class MessageForwardedPost
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x156CD668u:
                    this.author_signature = reader.ReadStringAsUTF16String();
                    return true;
                case 0xAA9E377Au:
                    this.date = reader.ReadInt();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
                case 0xF88B1654u:
                    this.forwarded_from_chat_id = reader.ReadLong();
                    return true;
                case 0x4645CC3Eu:
                    this.forwarded_from_message_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5465BC28u)]
    public partial class MessageSendingStatePending { }
    [TLTypeHash(0x4B2AF9E2u)]
    public partial class MessageSendingStateFailed { }
    [TLTypeHash(0xB6BD307Fu)]
    public partial class Message
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadLong();
                    return true;
                case 0x2A98155Eu:
                    this.sender_user_id = reader.ReadInt();
                    return true;
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x81CC3C3Du:
                    this.sending_state = (MessageSendingState)reader.ReadValue();
                    return true;
                case 0xF05AA554u:
                    this.is_outgoing = reader.ReadBool();
                    return true;
                case 0x090C23EFu:
                    this.can_be_edited = reader.ReadBool();
                    return true;
                case 0xF0331819u:
                    this.can_be_forwarded = reader.ReadBool();
                    return true;
                case 0x6335FB7Cu:
                    this.can_be_deleted_only_for_self = reader.ReadBool();
                    return true;
                case 0x0EC2C6CDu:
                    this.can_be_deleted_for_all_users = reader.ReadBool();
                    return true;
                case 0xE6602C2Du:
                    this.is_channel_post = reader.ReadBool();
                    return true;
                case 0xAED9C680u:
                    this.contains_unread_mention = reader.ReadBool();
                    return true;
                case 0xAA9E377Au:
                    this.date = reader.ReadInt();
                    return true;
                case 0x1B588899u:
                    this.edit_date = reader.ReadInt();
                    return true;
                case 0xBDB50CFAu:
                    this.forward_info = (MessageForwardInfo)reader.ReadValue();
                    return true;
                case 0x5518525Du:
                    this.reply_to_message_id = reader.ReadLong();
                    return true;
                case 0xA3EE881Fu:
                    this.ttl = reader.ReadInt();
                    return true;
                case 0x4787C306u:
                    this.ttl_expires_in = reader.ReadDouble();
                    return true;
                case 0x7F6BB42Au:
                    this.via_bot_user_id = reader.ReadInt();
                    return true;
                case 0x156CD668u:
                    this.author_signature = reader.ReadStringAsUTF16String();
                    return true;
                case 0x11F09C87u:
                    this.views = reader.ReadInt();
                    return true;
                case 0x1E56857Du:
                    this.media_album_id = reader.ReadIntegerString();
                    return true;
                case 0xFEC530A9u:
                    this.content = (MessageContent)reader.ReadValue();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDB021E96u)]
    public partial class Messages
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x46ABD250u:
                    this.total_count = reader.ReadInt();
                    return true;
                case 0xDB021E96u:
                    this.messages = reader.ReadArray<Message>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xFD26090Bu)]
    public partial class FoundMessages
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xDB021E96u:
                    this.messages = reader.ReadArray<Message>();
                    return true;
                case 0xD10A397Au:
                    this.next_from_search_id = reader.ReadIntegerString();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xFC70C5FFu)]
    public partial class NotificationSettingsScopePrivateChats { }
    [TLTypeHash(0x1153960Du)]
    public partial class NotificationSettingsScopeGroupChats { }
    [TLTypeHash(0x23C2F82Cu)]
    public partial class ChatNotificationSettings
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x87F9C7BEu:
                    this.use_default_mute_for = reader.ReadBool();
                    return true;
                case 0xD2A7ED7Bu:
                    this.mute_for = reader.ReadInt();
                    return true;
                case 0xB1A181A2u:
                    this.use_default_sound = reader.ReadBool();
                    return true;
                case 0xF88EC384u:
                    this.sound = reader.ReadStringAsUTF16String();
                    return true;
                case 0x95A70A70u:
                    this.use_default_show_preview = reader.ReadBool();
                    return true;
                case 0xDED702D3u:
                    this.show_preview = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x136D5FC6u)]
    public partial class ScopeNotificationSettings
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xD2A7ED7Bu:
                    this.mute_for = reader.ReadInt();
                    return true;
                case 0xF88EC384u:
                    this.sound = reader.ReadStringAsUTF16String();
                    return true;
                case 0xDED702D3u:
                    this.show_preview = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2BE5A4BDu)]
    public partial class DraftMessage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5518525Du:
                    this.reply_to_message_id = reader.ReadLong();
                    return true;
                case 0x945D433Du:
                    this.input_message_text = (InputMessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE5794EFFu)]
    public partial class ChatTypePrivate
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xEB40D445u)]
    public partial class ChatTypeBasicGroup
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1B6DFDDBu:
                    this.basic_group_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9264BE43u)]
    public partial class ChatTypeSupergroup
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x386CD096u:
                    this.supergroup_id = reader.ReadInt();
                    return true;
                case 0xB4C5088Fu:
                    this.is_channel = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xFB16360Eu)]
    public partial class ChatTypeSecret
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3C9AC102u:
                    this.secret_chat_id = reader.ReadInt();
                    return true;
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x659DF2AAu)]
    public partial class Chat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadLong();
                    return true;
                case 0x8CDE5729u:
                    this.type = (ChatType)reader.ReadValue();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x14B78418u:
                    this.photo = (ChatPhoto)reader.ReadValue();
                    return true;
                case 0xD0310C37u:
                    this.last_message = (Message)reader.ReadValue();
                    return true;
                case 0xF5299398u:
                    this.order = reader.ReadIntegerString();
                    return true;
                case 0xB56E6838u:
                    this.is_pinned = reader.ReadBool();
                    return true;
                case 0x890E79B0u:
                    this.is_marked_as_unread = reader.ReadBool();
                    return true;
                case 0x1398BEB0u:
                    this.is_sponsored = reader.ReadBool();
                    return true;
                case 0x5A05B511u:
                    this.can_be_reported = reader.ReadBool();
                    return true;
                case 0x420254ABu:
                    this.default_disable_notification = reader.ReadBool();
                    return true;
                case 0xFC4DDD75u:
                    this.unread_count = reader.ReadInt();
                    return true;
                case 0x1123A8C1u:
                    this.last_read_inbox_message_id = reader.ReadLong();
                    return true;
                case 0xF1D5DB98u:
                    this.last_read_outbox_message_id = reader.ReadLong();
                    return true;
                case 0xE9E0195Du:
                    this.unread_mention_count = reader.ReadInt();
                    return true;
                case 0xB0559860u:
                    this.notification_settings = (ChatNotificationSettings)reader.ReadValue();
                    return true;
                case 0xC37A0A68u:
                    this.reply_markup_message_id = reader.ReadLong();
                    return true;
                case 0x4E74485Cu:
                    this.draft_message = (DraftMessage)reader.ReadValue();
                    return true;
                case 0x7C6F3001u:
                    this.client_data = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2D68180Fu)]
    public partial class Chats
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5010813Du:
                    this.chat_ids = reader.ReadArray<long>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7C5F6254u)]
    public partial class ChatInviteLink
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2E98587Bu:
                    this.invite_link = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0017655Eu)]
    public partial class ChatInviteLinkInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x8CDE5729u:
                    this.type = (ChatType)reader.ReadValue();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x14B78418u:
                    this.photo = (ChatPhoto)reader.ReadValue();
                    return true;
                case 0xE7F8D191u:
                    this.member_count = reader.ReadInt();
                    return true;
                case 0x6C1165F9u:
                    this.member_user_ids = reader.ReadArray<int>();
                    return true;
                case 0x6BFDA3C2u:
                    this.is_public = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4B9B2001u)]
    public partial class KeyboardButtonTypeText { }
    [TLTypeHash(0x505BF414u)]
    public partial class KeyboardButtonTypeRequestPhoneNumber { }
    [TLTypeHash(0xB4D15F1Du)]
    public partial class KeyboardButtonTypeRequestLocation { }
    [TLTypeHash(0xC6C90C7Bu)]
    public partial class KeyboardButton
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = reader.ReadStringAsUTF16String();
                    return true;
                case 0x8CDE5729u:
                    this.type = (KeyboardButtonType)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x659C9AAFu)]
    public partial class InlineKeyboardButtonTypeUrl
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF47645AEu:
                    this.url = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF6811A74u)]
    public partial class InlineKeyboardButtonTypeCallback
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xADF3F363u:
                    this.data = reader.ReadBase64String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x00B371FCu)]
    public partial class InlineKeyboardButtonTypeCallbackGame { }
    [TLTypeHash(0xDE317F8Cu)]
    public partial class InlineKeyboardButtonTypeSwitchInline
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x24BDB5EBu:
                    this.query = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5BD83425u:
                    this.in_current_chat = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5E695D76u)]
    public partial class InlineKeyboardButtonTypeBuy { }
    [TLTypeHash(0x7C91E567u)]
    public partial class InlineKeyboardButton
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = reader.ReadStringAsUTF16String();
                    return true;
                case 0x8CDE5729u:
                    this.type = (InlineKeyboardButtonType)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xED8393BBu)]
    public partial class ReplyMarkupRemoveKeyboard
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x64231B80u:
                    this.is_personal = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x955B214Eu)]
    public partial class ReplyMarkupForceReply
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x64231B80u:
                    this.is_personal = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x45EC6D92u)]
    public partial class ReplyMarkupShowKeyboard
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x0A8BF4A1u:
                    this.rows = reader.ReadNestedArray<KeyboardButton>();
                    return true;
                case 0xA34CDB55u:
                    this.resize_keyboard = reader.ReadBool();
                    return true;
                case 0x1BCADB6Cu:
                    this.one_time = reader.ReadBool();
                    return true;
                case 0x64231B80u:
                    this.is_personal = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x64A96CA9u)]
    public partial class ReplyMarkupInlineKeyboard
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x0A8BF4A1u:
                    this.rows = reader.ReadNestedArray<InlineKeyboardButton>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8D63B881u)]
    public partial class RichTextPlain
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x579627EAu)]
    public partial class RichTextBold
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = (RichText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA148D45Du)]
    public partial class RichTextItalic
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = (RichText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1A3DDA94u)]
    public partial class RichTextUnderline
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = (RichText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5B517FEFu)]
    public partial class RichTextStrikethrough
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = (RichText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0A8A147Cu)]
    public partial class RichTextFixed
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = (RichText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x17FD66DFu)]
    public partial class RichTextUrl
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = (RichText)reader.ReadValue();
                    return true;
                case 0xF47645AEu:
                    this.url = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xCCBA0769u)]
    public partial class RichTextEmailAddress
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = (RichText)reader.ReadValue();
                    return true;
                case 0xB08E074Eu:
                    this.email_address = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB0D75484u)]
    public partial class RichTexts
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1E3513BFu:
                    this.texts = reader.ReadArray<RichText>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4893680Du)]
    public partial class PageBlockTitle
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2B36786Bu:
                    this.title = (RichText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF1A16576u)]
    public partial class PageBlockSubtitle
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x518597B1u:
                    this.subtitle = (RichText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x718827AFu)]
    public partial class PageBlockAuthorDate
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBDAFD8C8u:
                    this.author = (RichText)reader.ReadValue();
                    return true;
                case 0x78B553BAu:
                    this.publish_date = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xCAC0C9BCu)]
    public partial class PageBlockHeader
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x6E72A8C1u:
                    this.header = (RichText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0DAE5305u)]
    public partial class PageBlockSubheader
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x080E20E4u:
                    this.subheader = (RichText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7873EB83u)]
    public partial class PageBlockParagraph
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = (RichText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1C765474u)]
    public partial class PageBlockPreformatted
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = (RichText)reader.ReadValue();
                    return true;
                case 0xD4DB71B5u:
                    this.language = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4683642Eu)]
    public partial class PageBlockFooter
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xE2310553u:
                    this.footer = (RichText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3A9D1712u)]
    public partial class PageBlockDivider { }
    [TLTypeHash(0xC3E37000u)]
    public partial class PageBlockAnchor
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5E237E06u:
                    this.name = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE7B44705u)]
    public partial class PageBlockList
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xE11EE94Du:
                    this.items = reader.ReadArray<RichText>();
                    return true;
                case 0xD52E9951u:
                    this.is_ordered = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE6F3B40Du)]
    public partial class PageBlockBlockQuote
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = (RichText)reader.ReadValue();
                    return true;
                case 0xF67C4965u:
                    this.caption = (RichText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA808C133u)]
    public partial class PageBlockPullQuote
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = (RichText)reader.ReadValue();
                    return true;
                case 0xF67C4965u:
                    this.caption = (RichText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x88F2F73Du)]
    public partial class PageBlockAnimation
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8D5284DCu:
                    this.animation = (Animation)reader.ReadValue();
                    return true;
                case 0xF67C4965u:
                    this.caption = (RichText)reader.ReadValue();
                    return true;
                case 0x49F96AE7u:
                    this.need_autoplay = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7BD826F3u)]
    public partial class PageBlockAudio
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x187D3695u:
                    this.audio = (Audio)reader.ReadValue();
                    return true;
                case 0xF67C4965u:
                    this.caption = (RichText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7712947Eu)]
    public partial class PageBlockPhoto
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x14B78418u:
                    this.photo = (Photo)reader.ReadValue();
                    return true;
                case 0xF67C4965u:
                    this.caption = (RichText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1F62CA4Au)]
    public partial class PageBlockVideo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x7CC7DA2Cu:
                    this.video = (Video)reader.ReadValue();
                    return true;
                case 0xF67C4965u:
                    this.caption = (RichText)reader.ReadValue();
                    return true;
                case 0x49F96AE7u:
                    this.need_autoplay = reader.ReadBool();
                    return true;
                case 0xE03EB667u:
                    this.is_looped = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xEEAD96A3u)]
    public partial class PageBlockCover
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8D0886C5u:
                    this.cover = (PageBlock)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0A4DC133u)]
    public partial class PageBlockEmbedded
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF47645AEu:
                    this.url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x1879F8E5u:
                    this.html = reader.ReadStringAsUTF16String();
                    return true;
                case 0xE0332FDDu:
                    this.poster_photo = (Photo)reader.ReadValue();
                    return true;
                case 0x8C1A452Fu:
                    this.width = reader.ReadInt();
                    return true;
                case 0xF54DE50Fu:
                    this.height = reader.ReadInt();
                    return true;
                case 0xF67C4965u:
                    this.caption = (RichText)reader.ReadValue();
                    return true;
                case 0x24FF850Au:
                    this.is_full_width = reader.ReadBool();
                    return true;
                case 0x8C343DCEu:
                    this.allow_scrolling = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2D49B0DDu)]
    public partial class PageBlockEmbeddedPost
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF47645AEu:
                    this.url = reader.ReadStringAsUTF16String();
                    return true;
                case 0xBDAFD8C8u:
                    this.author = reader.ReadStringAsUTF16String();
                    return true;
                case 0x023FA4D5u:
                    this.author_photo = (Photo)reader.ReadValue();
                    return true;
                case 0xAA9E377Au:
                    this.date = reader.ReadInt();
                    return true;
                case 0xA13B6366u:
                    this.page_blocks = reader.ReadArray<PageBlock>();
                    return true;
                case 0xF67C4965u:
                    this.caption = (RichText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x83C3903Eu)]
    public partial class PageBlockCollage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA13B6366u:
                    this.page_blocks = reader.ReadArray<PageBlock>();
                    return true;
                case 0xF67C4965u:
                    this.caption = (RichText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x621097F1u)]
    public partial class PageBlockSlideshow
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA13B6366u:
                    this.page_blocks = reader.ReadArray<PageBlock>();
                    return true;
                case 0xF67C4965u:
                    this.caption = (RichText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5B1BFB57u)]
    public partial class PageBlockChatLink
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x14B78418u:
                    this.photo = (ChatPhoto)reader.ReadValue();
                    return true;
                case 0xF85E0677u:
                    this.username = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC534C87Fu)]
    public partial class WebPageInstantView
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA13B6366u:
                    this.page_blocks = reader.ReadArray<PageBlock>();
                    return true;
                case 0x758CFA81u:
                    this.is_full = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9A144D1Du)]
    public partial class WebPage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF47645AEu:
                    this.url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2023EEF4u:
                    this.display_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x8CDE5729u:
                    this.type = reader.ReadStringAsUTF16String();
                    return true;
                case 0x65B9C3FFu:
                    this.site_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x6DE44026u:
                    this.description = reader.ReadStringAsUTF16String();
                    return true;
                case 0x14B78418u:
                    this.photo = (Photo)reader.ReadValue();
                    return true;
                case 0x0BE8F4CFu:
                    this.embed_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0xB6949856u:
                    this.embed_type = reader.ReadStringAsUTF16String();
                    return true;
                case 0x4C9A634Du:
                    this.embed_width = reader.ReadInt();
                    return true;
                case 0x5631655Du:
                    this.embed_height = reader.ReadInt();
                    return true;
                case 0x865F80C0u:
                    this.duration = reader.ReadInt();
                    return true;
                case 0xBDAFD8C8u:
                    this.author = reader.ReadStringAsUTF16String();
                    return true;
                case 0x8D5284DCu:
                    this.animation = (Animation)reader.ReadValue();
                    return true;
                case 0x187D3695u:
                    this.audio = (Audio)reader.ReadValue();
                    return true;
                case 0xD8698A76u:
                    this.document = (Document)reader.ReadValue();
                    return true;
                case 0x8FEDBCFDu:
                    this.sticker = (Sticker)reader.ReadValue();
                    return true;
                case 0x7CC7DA2Cu:
                    this.video = (Video)reader.ReadValue();
                    return true;
                case 0xC82AA7C8u:
                    this.video_note = (VideoNote)reader.ReadValue();
                    return true;
                case 0xE27EDDCFu:
                    this.voice_note = (VoiceNote)reader.ReadValue();
                    return true;
                case 0xD031006Bu:
                    this.has_instant_view = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0D4E6F81u)]
    public partial class Address
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF026BB7Cu:
                    this.country_code = reader.ReadStringAsUTF16String();
                    return true;
                case 0xA393D2FBu:
                    this.state = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2D5B0234u:
                    this.city = reader.ReadStringAsUTF16String();
                    return true;
                case 0xEEB79EA6u:
                    this.street_line1 = reader.ReadStringAsUTF16String();
                    return true;
                case 0x77BECF1Cu:
                    this.street_line2 = reader.ReadStringAsUTF16String();
                    return true;
                case 0xEA98E376u:
                    this.postal_code = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB6674DA1u)]
    public partial class LabeledPricePart
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x0EA750E8u:
                    this.label = reader.ReadStringAsUTF16String();
                    return true;
                case 0x8EA17042u:
                    this.amount = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x90651744u)]
    public partial class Invoice
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x6956883Fu:
                    this.currency = reader.ReadStringAsUTF16String();
                    return true;
                case 0x4289AF9Eu:
                    this.price_parts = reader.ReadArray<LabeledPricePart>();
                    return true;
                case 0x4D8C502Du:
                    this.is_test = reader.ReadBool();
                    return true;
                case 0x656C3749u:
                    this.need_name = reader.ReadBool();
                    return true;
                case 0x62D06D9Eu:
                    this.need_phone_number = reader.ReadBool();
                    return true;
                case 0x5B89E0A0u:
                    this.need_email_address = reader.ReadBool();
                    return true;
                case 0xC721648Cu:
                    this.need_shipping_address = reader.ReadBool();
                    return true;
                case 0x5F61FB81u:
                    this.send_phone_number_to_provider = reader.ReadBool();
                    return true;
                case 0x3EFC17F7u:
                    this.send_email_address_to_provider = reader.ReadBool();
                    return true;
                case 0xC26F059Cu:
                    this.is_flexible = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x658BC8F3u)]
    public partial class OrderInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5E237E06u:
                    this.name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x6B01BC5Bu:
                    this.phone_number = reader.ReadStringAsUTF16String();
                    return true;
                case 0xB08E074Eu:
                    this.email_address = reader.ReadStringAsUTF16String();
                    return true;
                case 0xEB066945u:
                    this.shipping_address = (Address)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x398D34A0u)]
    public partial class ShippingOption
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x4289AF9Eu:
                    this.price_parts = reader.ReadArray<LabeledPricePart>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDCEB0249u)]
    public partial class SavedCredentials
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1D911F70u)]
    public partial class InputCredentialsSaved
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x34BD29D9u:
                    this.saved_credentials_id = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB4527F8Bu)]
    public partial class InputCredentialsNew
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xADF3F363u:
                    this.data = reader.ReadStringAsUTF16String();
                    return true;
                case 0x45047CD1u:
                    this.allow_save = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2710DCB7u)]
    public partial class InputCredentialsAndroidPay
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xADF3F363u:
                    this.data = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x44A3E6F8u)]
    public partial class InputCredentialsApplePay
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xADF3F363u:
                    this.data = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x954FE522u)]
    public partial class PaymentsProviderStripe
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xE5DB58DFu:
                    this.publishable_key = reader.ReadStringAsUTF16String();
                    return true;
                case 0xEF6DABEDu:
                    this.need_country = reader.ReadBool();
                    return true;
                case 0x8D050D7Au:
                    this.need_postal_code = reader.ReadBool();
                    return true;
                case 0xE4605CDDu:
                    this.need_cardholder_name = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x88B28ABFu)]
    public partial class PaymentForm
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x90651744u:
                    this.invoice = (Invoice)reader.ReadValue();
                    return true;
                case 0xF47645AEu:
                    this.url = reader.ReadStringAsUTF16String();
                    return true;
                case 0xAA4CFA8Au:
                    this.payments_provider = (PaymentsProviderStripe)reader.ReadValue();
                    return true;
                case 0x45415EA8u:
                    this.saved_order_info = (OrderInfo)reader.ReadValue();
                    return true;
                case 0x54177B11u:
                    this.saved_credentials = (SavedCredentials)reader.ReadValue();
                    return true;
                case 0x92127D7Au:
                    this.can_save_credentials = reader.ReadBool();
                    return true;
                case 0x4F14021Fu:
                    this.need_password = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x67C70EE2u)]
    public partial class ValidatedOrderInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xABF168B3u:
                    this.order_info_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x367DFC43u:
                    this.shipping_options = reader.ReadArray<ShippingOption>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC9B71E0Bu)]
    public partial class PaymentResult
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x6F00DFB2u:
                    this.success = reader.ReadBool();
                    return true;
                case 0x7F61E7E8u:
                    this.verification_url = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x402FF3CCu)]
    public partial class PaymentReceipt
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xAA9E377Au:
                    this.date = reader.ReadInt();
                    return true;
                case 0x93DE834Du:
                    this.payments_provider_user_id = reader.ReadInt();
                    return true;
                case 0x90651744u:
                    this.invoice = (Invoice)reader.ReadValue();
                    return true;
                case 0x86780B40u:
                    this.order_info = (OrderInfo)reader.ReadValue();
                    return true;
                case 0x71DCC5FFu:
                    this.shipping_option = (ShippingOption)reader.ReadValue();
                    return true;
                case 0xE5389776u:
                    this.credentials_title = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDA82994Du)]
    public partial class DatedFile
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8C9F3610u:
                    this.file = (File)reader.ReadValue();
                    return true;
                case 0xAA9E377Au:
                    this.date = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x405E6A6Bu)]
    public partial class PassportElementTypePersonalDetails { }
    [TLTypeHash(0xBAFB1EE1u)]
    public partial class PassportElementTypePassport { }
    [TLTypeHash(0x8EB7F87Cu)]
    public partial class PassportElementTypeDriverLicense { }
    [TLTypeHash(0x4C2BCEE4u)]
    public partial class PassportElementTypeIdentityCard { }
    [TLTypeHash(0xF9A28C9Au)]
    public partial class PassportElementTypeInternalPassport { }
    [TLTypeHash(0x54C7B2C8u)]
    public partial class PassportElementTypeAddress { }
    [TLTypeHash(0x76673EACu)]
    public partial class PassportElementTypeUtilityBill { }
    [TLTypeHash(0xF7A480F0u)]
    public partial class PassportElementTypeBankStatement { }
    [TLTypeHash(0x4248D73Du)]
    public partial class PassportElementTypeRentalAgreement { }
    [TLTypeHash(0x60CFE178u)]
    public partial class PassportElementTypePassportRegistration { }
    [TLTypeHash(0x34871EDBu)]
    public partial class PassportElementTypeTemporaryRegistration { }
    [TLTypeHash(0x73E5F862u)]
    public partial class PassportElementTypePhoneNumber { }
    [TLTypeHash(0x421AFF00u)]
    public partial class PassportElementTypeEmailAddress { }
    [TLTypeHash(0xAA9E377Au)]
    public partial class Date
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xE5A02990u:
                    this.day = reader.ReadInt();
                    return true;
                case 0x8EB61006u:
                    this.month = reader.ReadInt();
                    return true;
                case 0xBB827337u:
                    this.year = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB0243982u)]
    public partial class PersonalDetails
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA9D1C132u:
                    this.first_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x59107AF8u:
                    this.middle_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0xC808BA5Au:
                    this.last_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0xC951B572u:
                    this.native_first_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2FACBB1Cu:
                    this.native_middle_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0xF8F22FC5u:
                    this.native_last_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x92E45C23u:
                    this.birthdate = (Date)reader.ReadValue();
                    return true;
                case 0xC7470A42u:
                    this.gender = reader.ReadStringAsUTF16String();
                    return true;
                case 0xF026BB7Cu:
                    this.country_code = reader.ReadStringAsUTF16String();
                    return true;
                case 0xDA2EF34Bu:
                    this.residence_country_code = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD7E2AA35u)]
    public partial class IdentityDocument
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x96901F54u:
                    this.number = reader.ReadStringAsUTF16String();
                    return true;
                case 0xF6DE1BC8u:
                    this.expiry_date = (Date)reader.ReadValue();
                    return true;
                case 0x1B51A1D9u:
                    this.front_side = (DatedFile)reader.ReadValue();
                    return true;
                case 0xACCE8C4Bu:
                    this.reverse_side = (DatedFile)reader.ReadValue();
                    return true;
                case 0xD9EB9CE1u:
                    this.selfie = (DatedFile)reader.ReadValue();
                    return true;
                case 0xB469456Fu:
                    this.translation = reader.ReadArray<DatedFile>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC07FBB08u)]
    public partial class InputIdentityDocument
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x96901F54u:
                    this.number = reader.ReadStringAsUTF16String();
                    return true;
                case 0xF6DE1BC8u:
                    this.expiry_date = (Date)reader.ReadValue();
                    return true;
                case 0x1B51A1D9u:
                    this.front_side = (InputFile)reader.ReadValue();
                    return true;
                case 0xACCE8C4Bu:
                    this.reverse_side = (InputFile)reader.ReadValue();
                    return true;
                case 0xD9EB9CE1u:
                    this.selfie = (InputFile)reader.ReadValue();
                    return true;
                case 0xB469456Fu:
                    this.translation = reader.ReadArray<InputFile>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD6700076u)]
    public partial class PersonalDocument
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x06354059u:
                    this.files = reader.ReadArray<DatedFile>();
                    return true;
                case 0xB469456Fu:
                    this.translation = reader.ReadArray<DatedFile>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC1ED114Bu)]
    public partial class InputPersonalDocument
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x06354059u:
                    this.files = reader.ReadArray<InputFile>();
                    return true;
                case 0xB469456Fu:
                    this.translation = reader.ReadArray<InputFile>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD34BEB8Eu)]
    public partial class PassportElementPersonalDetails
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF10102A1u:
                    this.personal_details = (PersonalDetails)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5078709Au)]
    public partial class PassportElementPassport
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xB5A26E08u:
                    this.passport = (IdentityDocument)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9CAE172Du)]
    public partial class PassportElementDriverLicense
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x92979079u:
                    this.driver_license = (IdentityDocument)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE22DCFBDu)]
    public partial class PassportElementIdentityCard
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x98195157u:
                    this.identity_card = (IdentityDocument)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x29518FECu)]
    public partial class PassportElementInternalPassport
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x7A00E3D0u:
                    this.internal_passport = (IdentityDocument)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x02EEF04Cu)]
    public partial class PassportElementAddress
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x0D4E6F81u:
                    this.address = (Address)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA10C2D44u)]
    public partial class PassportElementUtilityBill
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x04EAC1B4u:
                    this.utility_bill = (PersonalDocument)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE5BD6FA1u)]
    public partial class PassportElementBankStatement
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xB33607EFu:
                    this.bank_statement = (PersonalDocument)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD15D56D8u)]
    public partial class PassportElementRentalAgreement
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x91855D2Bu:
                    this.rental_agreement = (PersonalDocument)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x959FC0CBu)]
    public partial class PassportElementPassportRegistration
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x625DEA81u:
                    this.passport_registration = (PersonalDocument)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x661AACCCu)]
    public partial class PassportElementTemporaryRegistration
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xFB4EEB01u:
                    this.temporary_registration = (PersonalDocument)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA48EEB8Au)]
    public partial class PassportElementPhoneNumber
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x6B01BC5Bu:
                    this.phone_number = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xEC1CFE59u)]
    public partial class PassportElementEmailAddress
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xB08E074Eu:
                    this.email_address = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD34BF284u)]
    public partial class InputPassportElementPersonalDetails
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF10102A1u:
                    this.personal_details = (PersonalDetails)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB51EE9B1u)]
    public partial class InputPassportElementPassport
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xB5A26E08u:
                    this.passport = (InputIdentityDocument)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x85A4172Du)]
    public partial class InputPassportElementDriverLicense
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x92979079u:
                    this.driver_license = (InputIdentityDocument)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x841BBE2Bu)]
    public partial class InputPassportElementIdentityCard
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x98195157u:
                    this.identity_card = (InputIdentityDocument)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC98466EBu)]
    public partial class InputPassportElementInternalPassport
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x7A00E3D0u:
                    this.internal_passport = (InputIdentityDocument)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB1C9D681u)]
    public partial class InputPassportElementAddress
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x0D4E6F81u:
                    this.address = (Address)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9146719Eu)]
    public partial class InputPassportElementUtilityBill
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x04EAC1B4u:
                    this.utility_bill = (InputPersonalDocument)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xFCB76FA1u)]
    public partial class InputPassportElementBankStatement
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xB33607EFu:
                    this.bank_statement = (InputPersonalDocument)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD15D4FD2u)]
    public partial class InputPassportElementRentalAgreement
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x91855D2Bu:
                    this.rental_agreement = (InputPersonalDocument)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF23EC07Fu)]
    public partial class InputPassportElementPassportRegistration
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x625DEA81u:
                    this.passport_registration = (InputPersonalDocument)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xAA717A59u)]
    public partial class InputPassportElementTemporaryRegistration
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xFB4EEB01u:
                    this.temporary_registration = (InputPersonalDocument)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x94C4B750u)]
    public partial class InputPassportElementPhoneNumber
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x6B01BC5Bu:
                    this.phone_number = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8A2A8FCFu)]
    public partial class InputPassportElementEmailAddress
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xB08E074Eu:
                    this.email_address = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x39A37E87u)]
    public partial class PassportElements
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x444A075Du:
                    this.elements = reader.ReadArray<PassportElement>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDE238CBBu)]
    public partial class PassportElementErrorSourceUnspecified { }
    [TLTypeHash(0xAE932485u)]
    public partial class PassportElementErrorSourceDataField
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x4DEF17BCu:
                    this.field_name = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x146DF0F3u)]
    public partial class PassportElementErrorSourceFrontSide { }
    [TLTypeHash(0xBC825C51u)]
    public partial class PassportElementErrorSourceReverseSide { }
    [TLTypeHash(0xD2A26910u)]
    public partial class PassportElementErrorSourceSelfie { }
    [TLTypeHash(0xCCD89BB5u)]
    public partial class PassportElementErrorSourceTranslationFile { }
    [TLTypeHash(0xA0C95093u)]
    public partial class PassportElementErrorSourceTranslationFiles { }
    [TLTypeHash(0x74C162DCu)]
    public partial class PassportElementErrorSourceFile { }
    [TLTypeHash(0x941F9096u)]
    public partial class PassportElementErrorSourceFiles { }
    [TLTypeHash(0x31C68D91u)]
    public partial class PassportElementError
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8CDE5729u:
                    this.type = (PassportElementType)reader.ReadValue();
                    return true;
                case 0xB6BD307Fu:
                    this.message = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5F8A7F73u:
                    this.source = (PassportElementErrorSource)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xEA9E20CBu)]
    public partial class PassportSuitableElement
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8CDE5729u:
                    this.type = (PassportElementType)reader.ReadValue();
                    return true;
                case 0x71324DCBu:
                    this.is_selfie_required = reader.ReadBool();
                    return true;
                case 0x7357BF65u:
                    this.is_translation_required = reader.ReadBool();
                    return true;
                case 0xDAE56710u:
                    this.is_native_name_required = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBD1228FFu)]
    public partial class PassportRequiredElement
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x6AFE0883u:
                    this.suitable_elements = reader.ReadArray<PassportSuitableElement>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE2F7C671u)]
    public partial class PassportAuthorizationForm
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadInt();
                    return true;
                case 0xDF0F24CAu:
                    this.required_elements = reader.ReadArray<PassportRequiredElement>();
                    return true;
                case 0x444A075Du:
                    this.elements = reader.ReadArray<PassportElement>();
                    return true;
                case 0x3C51531Du:
                    this.errors = reader.ReadArray<PassportElementError>();
                    return true;
                case 0x202BC9D3u:
                    this.privacy_policy_url = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x917B0F99u)]
    public partial class EncryptedCredentials
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xADF3F363u:
                    this.data = reader.ReadBase64String();
                    return true;
                case 0xD1B862B8u:
                    this.hash = reader.ReadBase64String();
                    return true;
                case 0x5CA2E8E5u:
                    this.secret = reader.ReadBase64String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD9EE5066u)]
    public partial class EncryptedPassportElement
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8CDE5729u:
                    this.type = (PassportElementType)reader.ReadValue();
                    return true;
                case 0xADF3F363u:
                    this.data = reader.ReadBase64String();
                    return true;
                case 0x1B51A1D9u:
                    this.front_side = (DatedFile)reader.ReadValue();
                    return true;
                case 0xACCE8C4Bu:
                    this.reverse_side = (DatedFile)reader.ReadValue();
                    return true;
                case 0xD9EB9CE1u:
                    this.selfie = (DatedFile)reader.ReadValue();
                    return true;
                case 0xB469456Fu:
                    this.translation = reader.ReadArray<DatedFile>();
                    return true;
                case 0x06354059u:
                    this.files = reader.ReadArray<DatedFile>();
                    return true;
                case 0x1D775834u:
                    this.value = reader.ReadStringAsUTF16String();
                    return true;
                case 0xD1B862B8u:
                    this.hash = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5E8A80A6u)]
    public partial class InputPassportElementErrorSourceUnspecified
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x92864341u:
                    this.element_hash = reader.ReadBase64String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC9322431u)]
    public partial class InputPassportElementErrorSourceDataField
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x4DEF17BCu:
                    this.field_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x6AF7A95Au:
                    this.data_hash = reader.ReadBase64String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x73CCF047u)]
    public partial class InputPassportElementErrorSourceFrontSide
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x58440AD6u:
                    this.file_hash = reader.ReadBase64String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3C2B504Cu)]
    public partial class InputPassportElementErrorSourceReverseSide
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x58440AD6u:
                    this.file_hash = reader.ReadBase64String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4C26295Au)]
    public partial class InputPassportElementErrorSourceSelfie
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x58440AD6u:
                    this.file_hash = reader.ReadBase64String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF5CC6913u)]
    public partial class InputPassportElementErrorSourceTranslationFile
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x58440AD6u:
                    this.file_hash = reader.ReadBase64String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9F4542BCu)]
    public partial class InputPassportElementErrorSourceTranslationFiles
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA7E87E58u:
                    this.file_hashes = reader.ReadBytesArray();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x74C17BD6u)]
    public partial class InputPassportElementErrorSourceFile
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x58440AD6u:
                    this.file_hash = reader.ReadBase64String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x74CA7991u)]
    public partial class InputPassportElementErrorSourceFiles
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA7E87E58u:
                    this.file_hashes = reader.ReadBytesArray();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x695F153Au)]
    public partial class InputPassportElementError
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8CDE5729u:
                    this.type = (PassportElementType)reader.ReadValue();
                    return true;
                case 0xB6BD307Fu:
                    this.message = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5F8A7F73u:
                    this.source = (InputPassportElementErrorSource)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xFFE79BEFu)]
    public partial class MessageText
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = (FormattedText)reader.ReadValue();
                    return true;
                case 0xD008BBD5u:
                    this.web_page = (WebPage)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2845870Eu)]
    public partial class MessageAnimation
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8D5284DCu:
                    this.animation = (Animation)reader.ReadValue();
                    return true;
                case 0xF67C4965u:
                    this.caption = (FormattedText)reader.ReadValue();
                    return true;
                case 0x0CEB653Au:
                    this.is_secret = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2D0CF253u)]
    public partial class MessageAudio
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x187D3695u:
                    this.audio = (Audio)reader.ReadValue();
                    return true;
                case 0xF67C4965u:
                    this.caption = (FormattedText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC5DF3351u)]
    public partial class MessageDocument
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xD8698A76u:
                    this.document = (Document)reader.ReadValue();
                    return true;
                case 0xF67C4965u:
                    this.caption = (FormattedText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x21C640DEu)]
    public partial class MessagePhoto
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x14B78418u:
                    this.photo = (Photo)reader.ReadValue();
                    return true;
                case 0xF67C4965u:
                    this.caption = (FormattedText)reader.ReadValue();
                    return true;
                case 0x0CEB653Au:
                    this.is_secret = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x18750FBBu)]
    public partial class MessageExpiredPhoto { }
    [TLTypeHash(0x8E44FFEDu)]
    public partial class MessageSticker
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8FEDBCFDu:
                    this.sticker = (Sticker)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x49B61EEAu)]
    public partial class MessageVideo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x7CC7DA2Cu:
                    this.video = (Video)reader.ReadValue();
                    return true;
                case 0xF67C4965u:
                    this.caption = (FormattedText)reader.ReadValue();
                    return true;
                case 0x0CEB653Au:
                    this.is_secret = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7005518Fu)]
    public partial class MessageExpiredVideo { }
    [TLTypeHash(0x7D6A8A06u)]
    public partial class MessageVideoNote
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xC82AA7C8u:
                    this.video_note = (VideoNote)reader.ReadValue();
                    return true;
                case 0xA7C194DBu:
                    this.is_viewed = reader.ReadBool();
                    return true;
                case 0x0CEB653Au:
                    this.is_secret = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x463B19FDu)]
    public partial class MessageVoiceNote
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xE27EDDCFu:
                    this.voice_note = (VoiceNote)reader.ReadValue();
                    return true;
                case 0xF67C4965u:
                    this.caption = (FormattedText)reader.ReadValue();
                    return true;
                case 0xF4E1F777u:
                    this.is_listened = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x432830ECu)]
    public partial class MessageLocation
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5E9E89CBu:
                    this.location = (Location)reader.ReadValue();
                    return true;
                case 0xA6EEA81Au:
                    this.live_period = reader.ReadInt();
                    return true;
                case 0x3A26F090u:
                    this.expires_in = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA4E0DFCBu)]
    public partial class MessageVenue
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x91911B0Du:
                    this.venue = (Venue)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4DCBA528u)]
    public partial class MessageContact
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x4C62E638u:
                    this.contact = (Contact)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE7470DA4u)]
    public partial class MessageGame
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x232B318Cu:
                    this.game = (Game)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x91CC5454u)]
    public partial class MessageInvoice
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x6DE44026u:
                    this.description = reader.ReadStringAsUTF16String();
                    return true;
                case 0x14B78418u:
                    this.photo = (Photo)reader.ReadValue();
                    return true;
                case 0x6956883Fu:
                    this.currency = reader.ReadStringAsUTF16String();
                    return true;
                case 0x46B55354u:
                    this.total_amount = reader.ReadLong();
                    return true;
                case 0xE25FEAD6u:
                    this.start_parameter = reader.ReadStringAsUTF16String();
                    return true;
                case 0x4D8C502Du:
                    this.is_test = reader.ReadBool();
                    return true;
                case 0xC721648Cu:
                    this.need_shipping_address = reader.ReadBool();
                    return true;
                case 0xA959ADC2u:
                    this.receipt_message_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x08E21316u)]
    public partial class MessageCall
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBC7890D3u:
                    this.discard_reason = (CallDiscardReason)reader.ReadValue();
                    return true;
                case 0x865F80C0u:
                    this.duration = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7F16AF42u)]
    public partial class MessageBasicGroupChatCreate
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x6C1165F9u:
                    this.member_user_ids = reader.ReadArray<int>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBF892D6Bu)]
    public partial class MessageSupergroupChatCreate
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xFC08639Fu)]
    public partial class MessageChatChangeTitle
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC3899FECu)]
    public partial class MessageChatChangePhoto
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x14B78418u:
                    this.photo = (Photo)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE55F7C8Du)]
    public partial class MessageChatDeletePhoto { }
    [TLTypeHash(0x904583F4u)]
    public partial class MessageChatAddMembers
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x6C1165F9u:
                    this.member_user_ids = reader.ReadArray<int>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBC8530A0u)]
    public partial class MessageChatJoinByLink { }
    [TLTypeHash(0xF070754Bu)]
    public partial class MessageChatDeleteMember
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x107102B7u)]
    public partial class MessageChatUpgradeTo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x386CD096u:
                    this.supergroup_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3BDB9E67u)]
    public partial class MessageChatUpgradeFrom
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x1B6DFDDBu:
                    this.basic_group_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xAC761AFEu)]
    public partial class MessagePinMessage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x21F7CB23u)]
    public partial class MessageScreenshotTaken { }
    [TLTypeHash(0x0988A61Du)]
    public partial class MessageChatSetTtl
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA3EE881Fu:
                    this.ttl = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF00C11D2u)]
    public partial class MessageCustomServiceAction
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE07F07B0u)]
    public partial class MessageGameScore
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBDA6D4C4u:
                    this.game_message_id = reader.ReadLong();
                    return true;
                case 0xE48FD905u:
                    this.game_id = reader.ReadIntegerString();
                    return true;
                case 0x32993751u:
                    this.score = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF701F95Du)]
    public partial class MessagePaymentSuccessful
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xAAA663B7u:
                    this.invoice_message_id = reader.ReadLong();
                    return true;
                case 0x6956883Fu:
                    this.currency = reader.ReadStringAsUTF16String();
                    return true;
                case 0x46B55354u:
                    this.total_amount = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xEF4F9587u)]
    public partial class MessagePaymentSuccessfulBot
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xAAA663B7u:
                    this.invoice_message_id = reader.ReadLong();
                    return true;
                case 0x6956883Fu:
                    this.currency = reader.ReadStringAsUTF16String();
                    return true;
                case 0x46B55354u:
                    this.total_amount = reader.ReadLong();
                    return true;
                case 0xB0F55CC6u:
                    this.invoice_payload = reader.ReadBase64String();
                    return true;
                case 0xE1314C58u:
                    this.shipping_option_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x86780B40u:
                    this.order_info = (OrderInfo)reader.ReadValue();
                    return true;
                case 0x8E6B7922u:
                    this.telegram_payment_charge_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x756A0F54u:
                    this.provider_payment_charge_id = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF40A29EFu)]
    public partial class MessageContactRegistered { }
    [TLTypeHash(0x752C549Cu)]
    public partial class MessageWebsiteConnected
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF3FF5361u:
                    this.domain_name = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7C45C665u)]
    public partial class MessagePassportDataSent
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x59308930u:
                    this.types = reader.ReadArray<PassportElementType>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x05908F32u)]
    public partial class MessagePassportDataReceived
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x444A075Du:
                    this.elements = reader.ReadArray<EncryptedPassportElement>();
                    return true;
                case 0xFA05280Eu:
                    this.credentials = (EncryptedCredentials)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x10F6E704u)]
    public partial class MessageUnsupported { }
    [TLTypeHash(0x0B7F265Eu)]
    public partial class TextEntityTypeMention { }
    [TLTypeHash(0xB3C855F2u)]
    public partial class TextEntityTypeHashtag { }
    [TLTypeHash(0xB1CF0108u)]
    public partial class TextEntityTypeCashtag { }
    [TLTypeHash(0x38050FEAu)]
    public partial class TextEntityTypeBotCommand { }
    [TLTypeHash(0x862245EDu)]
    public partial class TextEntityTypeUrl { }
    [TLTypeHash(0x30353CC2u)]
    public partial class TextEntityTypeEmailAddress { }
    [TLTypeHash(0x9FD0A949u)]
    public partial class TextEntityTypeBold { }
    [TLTypeHash(0x2E625D16u)]
    public partial class TextEntityTypeItalic { }
    [TLTypeHash(0x98B274B2u)]
    public partial class TextEntityTypeCode { }
    [TLTypeHash(0xF9353FA2u)]
    public partial class TextEntityTypePre { }
    [TLTypeHash(0x7922648Bu)]
    public partial class TextEntityTypePreCode
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xD4DB71B5u:
                    this.language = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2A8A8CA5u)]
    public partial class TextEntityTypeTextUrl
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF47645AEu:
                    this.url = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD6762F4Au)]
    public partial class TextEntityTypeMentionName
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5B41BFA4u)]
    public partial class TextEntityTypePhoneNumber { }
    [TLTypeHash(0xF417350Cu)]
    public partial class InputThumbnail
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xC35726E6u:
                    this.thumbnail = (InputFile)reader.ReadValue();
                    return true;
                case 0x8C1A452Fu:
                    this.width = reader.ReadInt();
                    return true;
                case 0xF54DE50Fu:
                    this.height = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDFC8F617u)]
    public partial class InputMessageText
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = (FormattedText)reader.ReadValue();
                    return true;
                case 0x69F12077u:
                    this.disable_web_page_preview = reader.ReadBool();
                    return true;
                case 0x65AEDB4Cu:
                    this.clear_draft = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3FD89633u)]
    public partial class InputMessageAnimation
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8D5284DCu:
                    this.animation = (InputFile)reader.ReadValue();
                    return true;
                case 0xC35726E6u:
                    this.thumbnail = (InputThumbnail)reader.ReadValue();
                    return true;
                case 0x865F80C0u:
                    this.duration = reader.ReadInt();
                    return true;
                case 0x8C1A452Fu:
                    this.width = reader.ReadInt();
                    return true;
                case 0xF54DE50Fu:
                    this.height = reader.ReadInt();
                    return true;
                case 0xF67C4965u:
                    this.caption = (FormattedText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9E4AA710u)]
    public partial class InputMessageAudio
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x187D3695u:
                    this.audio = (InputFile)reader.ReadValue();
                    return true;
                case 0xBC627951u:
                    this.album_cover_thumbnail = (InputThumbnail)reader.ReadValue();
                    return true;
                case 0x865F80C0u:
                    this.duration = reader.ReadInt();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x17210BEBu:
                    this.performer = reader.ReadStringAsUTF16String();
                    return true;
                case 0xF67C4965u:
                    this.caption = (FormattedText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xEF704DCFu)]
    public partial class InputMessageDocument
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xD8698A76u:
                    this.document = (InputFile)reader.ReadValue();
                    return true;
                case 0xC35726E6u:
                    this.thumbnail = (InputThumbnail)reader.ReadValue();
                    return true;
                case 0xF67C4965u:
                    this.caption = (FormattedText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9280159Du)]
    public partial class InputMessagePhoto
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x14B78418u:
                    this.photo = (InputFile)reader.ReadValue();
                    return true;
                case 0xC35726E6u:
                    this.thumbnail = (InputThumbnail)reader.ReadValue();
                    return true;
                case 0x2E8A75B5u:
                    this.added_sticker_file_ids = reader.ReadArray<int>();
                    return true;
                case 0x8C1A452Fu:
                    this.width = reader.ReadInt();
                    return true;
                case 0xF54DE50Fu:
                    this.height = reader.ReadInt();
                    return true;
                case 0xF67C4965u:
                    this.caption = (FormattedText)reader.ReadValue();
                    return true;
                case 0xA3EE881Fu:
                    this.ttl = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4E11F516u)]
    public partial class InputMessageSticker
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8FEDBCFDu:
                    this.sticker = (InputFile)reader.ReadValue();
                    return true;
                case 0xC35726E6u:
                    this.thumbnail = (InputThumbnail)reader.ReadValue();
                    return true;
                case 0x8C1A452Fu:
                    this.width = reader.ReadInt();
                    return true;
                case 0xF54DE50Fu:
                    this.height = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xFAF04BA9u)]
    public partial class InputMessageVideo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x7CC7DA2Cu:
                    this.video = (InputFile)reader.ReadValue();
                    return true;
                case 0xC35726E6u:
                    this.thumbnail = (InputThumbnail)reader.ReadValue();
                    return true;
                case 0x2E8A75B5u:
                    this.added_sticker_file_ids = reader.ReadArray<int>();
                    return true;
                case 0x865F80C0u:
                    this.duration = reader.ReadInt();
                    return true;
                case 0x8C1A452Fu:
                    this.width = reader.ReadInt();
                    return true;
                case 0xF54DE50Fu:
                    this.height = reader.ReadInt();
                    return true;
                case 0xC5ED604Eu:
                    this.supports_streaming = reader.ReadBool();
                    return true;
                case 0xF67C4965u:
                    this.caption = (FormattedText)reader.ReadValue();
                    return true;
                case 0xA3EE881Fu:
                    this.ttl = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x6AF79B3Bu)]
    public partial class InputMessageVideoNote
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xC82AA7C8u:
                    this.video_note = (InputFile)reader.ReadValue();
                    return true;
                case 0xC35726E6u:
                    this.thumbnail = (InputThumbnail)reader.ReadValue();
                    return true;
                case 0x865F80C0u:
                    this.duration = reader.ReadInt();
                    return true;
                case 0x017D9EB2u:
                    this.length = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x51A608C0u)]
    public partial class InputMessageVoiceNote
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xE27EDDCFu:
                    this.voice_note = (InputFile)reader.ReadValue();
                    return true;
                case 0x865F80C0u:
                    this.duration = reader.ReadInt();
                    return true;
                case 0x11133403u:
                    this.waveform = reader.ReadBase64String();
                    return true;
                case 0xF67C4965u:
                    this.caption = (FormattedText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x69874E72u)]
    public partial class InputMessageLocation
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5E9E89CBu:
                    this.location = (Location)reader.ReadValue();
                    return true;
                case 0xA6EEA81Au:
                    this.live_period = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x17A68A88u)]
    public partial class InputMessageVenue
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x91911B0Du:
                    this.venue = (Venue)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8D9EAFD3u)]
    public partial class InputMessageContact
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x4C62E638u:
                    this.contact = (Contact)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC768605Cu)]
    public partial class InputMessageGame
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5898BEB0u:
                    this.bot_user_id = reader.ReadInt();
                    return true;
                case 0xD038777Eu:
                    this.game_short_name = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x51995EAFu)]
    public partial class InputMessageInvoice
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x90651744u:
                    this.invoice = (Invoice)reader.ReadValue();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x6DE44026u:
                    this.description = reader.ReadStringAsUTF16String();
                    return true;
                case 0x7BD27C7Au:
                    this.photo_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x76F1969Eu:
                    this.photo_size = reader.ReadInt();
                    return true;
                case 0x364B4298u:
                    this.photo_width = reader.ReadInt();
                    return true;
                case 0xA0F29227u:
                    this.photo_height = reader.ReadInt();
                    return true;
                case 0x422C6A15u:
                    this.payload = reader.ReadBase64String();
                    return true;
                case 0x0661144Fu:
                    this.provider_token = reader.ReadStringAsUTF16String();
                    return true;
                case 0x487B901Fu:
                    this.provider_data = reader.ReadStringAsUTF16String();
                    return true;
                case 0xE25FEAD6u:
                    this.start_parameter = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x670EDFB6u)]
    public partial class InputMessageForwarded
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x9CC4928Au:
                    this.from_chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
                case 0x92888C63u:
                    this.in_game_share = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD7904972u)]
    public partial class SearchMessagesFilterEmpty { }
    [TLTypeHash(0x48973098u)]
    public partial class SearchMessagesFilterAnimation { }
    [TLTypeHash(0xA72A4223u)]
    public partial class SearchMessagesFilterAudio { }
    [TLTypeHash(0xA7E670CEu)]
    public partial class SearchMessagesFilterDocument { }
    [TLTypeHash(0xABE0F0AEu)]
    public partial class SearchMessagesFilterPhoto { }
    [TLTypeHash(0xC390AE9Au)]
    public partial class SearchMessagesFilterVideo { }
    [TLTypeHash(0x26E9AE6Bu)]
    public partial class SearchMessagesFilterVoiceNote { }
    [TLTypeHash(0x79D71FB9u)]
    public partial class SearchMessagesFilterPhotoAndVideo { }
    [TLTypeHash(0xE975A43Fu)]
    public partial class SearchMessagesFilterUrl { }
    [TLTypeHash(0xEB0AF202u)]
    public partial class SearchMessagesFilterChatPhoto { }
    [TLTypeHash(0x4B9B8F0Du)]
    public partial class SearchMessagesFilterCall { }
    [TLTypeHash(0xC00BDCC9u)]
    public partial class SearchMessagesFilterMissedCall { }
    [TLTypeHash(0x1DB83D90u)]
    public partial class SearchMessagesFilterVideoNote { }
    [TLTypeHash(0xBE384132u)]
    public partial class SearchMessagesFilterVoiceAndVideoNote { }
    [TLTypeHash(0x07F55A81u)]
    public partial class SearchMessagesFilterMention { }
    [TLTypeHash(0xDC841A1Eu)]
    public partial class SearchMessagesFilterUnreadMention { }
    [TLTypeHash(0xC28635A3u)]
    public partial class ChatActionTyping { }
    [TLTypeHash(0xDB2CB409u)]
    public partial class ChatActionRecordingVideo { }
    [TLTypeHash(0xA9C4AE9Au)]
    public partial class ChatActionUploadingVideo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2201F246u:
                    this.progress = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC3B1BF65u)]
    public partial class ChatActionRecordingVoiceNote { }
    [TLTypeHash(0x5559BE7Du)]
    public partial class ChatActionUploadingVoiceNote
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2201F246u:
                    this.progress = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC1B4F0AEu)]
    public partial class ChatActionUploadingPhoto
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2201F246u:
                    this.progress = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xCBE0E549u)]
    public partial class ChatActionUploadingDocument
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2201F246u:
                    this.progress = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8836A083u)]
    public partial class ChatActionChoosingLocation { }
    [TLTypeHash(0x32E84698u)]
    public partial class ChatActionChoosingContact { }
    [TLTypeHash(0xD32C3D93u)]
    public partial class ChatActionStartPlayingGame { }
    [TLTypeHash(0xF8E02C9Eu)]
    public partial class ChatActionRecordingVideoNote { }
    [TLTypeHash(0x6E082D86u)]
    public partial class ChatActionUploadingVideoNote
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2201F246u:
                    this.progress = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x45B27EFAu)]
    public partial class ChatActionCancel { }
    [TLTypeHash(0x8E95760Cu)]
    public partial class UserStatusEmpty { }
    [TLTypeHash(0x0B6BA623u)]
    public partial class UserStatusOnline
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x9A9C688Cu:
                    this.expires = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3A30C53Eu)]
    public partial class UserStatusOffline
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x64B57314u:
                    this.was_online = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xECAF6388u)]
    public partial class UserStatusRecently { }
    [TLTypeHash(0x9D3B6C46u)]
    public partial class UserStatusLastWeek { }
    [TLTypeHash(0x8AAB5716u)]
    public partial class UserStatusLastMonth { }
    [TLTypeHash(0xD88DAC16u)]
    public partial class Stickers
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xD88DAC16u:
                    this.stickers = reader.ReadArray<Sticker>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x6684FAC1u)]
    public partial class StickerEmojis
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xD36FD57Du:
                    this.emojis = reader.ReadArray<string>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF58EFC41u)]
    public partial class StickerSet
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadIntegerString();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5E237E06u:
                    this.name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5F596777u:
                    this.is_installed = reader.ReadBool();
                    return true;
                case 0xF4181FFAu:
                    this.is_archived = reader.ReadBool();
                    return true;
                case 0x0DDE4409u:
                    this.is_official = reader.ReadBool();
                    return true;
                case 0x71547314u:
                    this.is_masks = reader.ReadBool();
                    return true;
                case 0xA7C194DBu:
                    this.is_viewed = reader.ReadBool();
                    return true;
                case 0xD88DAC16u:
                    this.stickers = reader.ReadArray<Sticker>();
                    return true;
                case 0xD36FD57Du:
                    this.emojis = reader.ReadArray<StickerEmojis>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9C1A98D3u)]
    public partial class StickerSetInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadIntegerString();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5E237E06u:
                    this.name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5F596777u:
                    this.is_installed = reader.ReadBool();
                    return true;
                case 0xF4181FFAu:
                    this.is_archived = reader.ReadBool();
                    return true;
                case 0x0DDE4409u:
                    this.is_official = reader.ReadBool();
                    return true;
                case 0x71547314u:
                    this.is_masks = reader.ReadBool();
                    return true;
                case 0xA7C194DBu:
                    this.is_viewed = reader.ReadBool();
                    return true;
                case 0xF7C0246Au:
                    this.size = reader.ReadInt();
                    return true;
                case 0xF08DF1B2u:
                    this.covers = reader.ReadArray<Sticker>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1A2030F1u)]
    public partial class StickerSets
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x46ABD250u:
                    this.total_count = reader.ReadInt();
                    return true;
                case 0x948D45D1u:
                    this.sets = reader.ReadArray<StickerSetInfo>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE04EB223u)]
    public partial class CallDiscardReasonEmpty { }
    [TLTypeHash(0xD204B597u)]
    public partial class CallDiscardReasonMissed { }
    [TLTypeHash(0xE84FE87Fu)]
    public partial class CallDiscardReasonDeclined { }
    [TLTypeHash(0x27227986u)]
    public partial class CallDiscardReasonDisconnected { }
    [TLTypeHash(0x5B1938C7u)]
    public partial class CallDiscardReasonHungUp { }
    [TLTypeHash(0x905BA652u)]
    public partial class CallProtocol
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3361DF98u:
                    this.udp_p2p = reader.ReadBool();
                    return true;
                case 0x931FA502u:
                    this.udp_reflector = reader.ReadBool();
                    return true;
                case 0x80299250u:
                    this.min_layer = reader.ReadInt();
                    return true;
                case 0x57C22011u:
                    this.max_layer = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x00D4ED58u)]
    public partial class CallConnection
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadIntegerString();
                    return true;
                case 0xA5E3B32Du:
                    this.ip = reader.ReadStringAsUTF16String();
                    return true;
                case 0x8544442Cu:
                    this.ipv6 = reader.ReadStringAsUTF16String();
                    return true;
                case 0x43915DCCu:
                    this.port = reader.ReadInt();
                    return true;
                case 0xA4717198u:
                    this.peer_tag = reader.ReadBase64String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC0A9A958u)]
    public partial class CallId
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBDEDF714u)]
    public partial class CallStatePending
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA4013170u:
                    this.is_created = reader.ReadBool();
                    return true;
                case 0x5CC54FC3u:
                    this.is_received = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9D5464DCu)]
    public partial class CallStateExchangingKeys { }
    [TLTypeHash(0x09B1CD48u)]
    public partial class CallStateReady
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xC8C0BC4Cu:
                    this.protocol = (CallProtocol)reader.ReadValue();
                    return true;
                case 0xBFF6FC15u:
                    this.connections = reader.ReadArray<CallConnection>();
                    return true;
                case 0xD48A2F7Cu:
                    this.config = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2186F990u:
                    this.encryption_key = reader.ReadBase64String();
                    return true;
                case 0xD36FD57Du:
                    this.emojis = reader.ReadArray<string>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xCEA15BE8u)]
    public partial class CallStateHangingUp { }
    [TLTypeHash(0x8B8DF360u)]
    public partial class CallStateDiscarded
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3BB8880Cu:
                    this.reason = (CallDiscardReason)reader.ReadValue();
                    return true;
                case 0xA068B793u:
                    this.need_rating = reader.ReadBool();
                    return true;
                case 0x936B15BAu:
                    this.need_debug_information = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7CF9F496u)]
    public partial class CallStateError
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5DDDBC71u:
                    this.error = (Error)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xCC8E2F3Eu)]
    public partial class Call
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadInt();
                    return true;
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0xF05AA554u:
                    this.is_outgoing = reader.ReadBool();
                    return true;
                case 0xA393D2FBu:
                    this.state = (CallState)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x94E60370u)]
    public partial class Animations
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x94E60370u:
                    this.animations = reader.ReadArray<Animation>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x6A82CA07u)]
    public partial class ImportedContacts
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x9BCCC613u:
                    this.user_ids = reader.ReadArray<int>();
                    return true;
                case 0x5FA5F178u:
                    this.importer_count = reader.ReadArray<int>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9F186236u)]
    public partial class InputInlineQueryResultAnimatedGif
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x815E207Bu:
                    this.thumbnail_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x72ADF222u:
                    this.gif_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x9EE94E6Cu:
                    this.gif_duration = reader.ReadInt();
                    return true;
                case 0x4E29329Cu:
                    this.gif_width = reader.ReadInt();
                    return true;
                case 0xA7E7344Eu:
                    this.gif_height = reader.ReadInt();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0x13348709u:
                    this.input_message_content = (InputMessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0596ABDEu)]
    public partial class InputInlineQueryResultAnimatedMpeg4
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x815E207Bu:
                    this.thumbnail_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0xE7F22263u:
                    this.mpeg4_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0xB6F891DEu:
                    this.mpeg4_duration = reader.ReadInt();
                    return true;
                case 0x21980B53u:
                    this.mpeg4_width = reader.ReadInt();
                    return true;
                case 0xAC535A56u:
                    this.mpeg4_height = reader.ReadInt();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0x13348709u:
                    this.input_message_content = (InputMessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5D924FFFu)]
    public partial class InputInlineQueryResultArticle
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0xF47645AEu:
                    this.url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x22EC5B68u:
                    this.hide_url = reader.ReadBool();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x6DE44026u:
                    this.description = reader.ReadStringAsUTF16String();
                    return true;
                case 0x815E207Bu:
                    this.thumbnail_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x4D8D948Au:
                    this.thumbnail_width = reader.ReadInt();
                    return true;
                case 0x533025B9u:
                    this.thumbnail_height = reader.ReadInt();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0x13348709u:
                    this.input_message_content = (InputMessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB66449FFu)]
    public partial class InputInlineQueryResultAudio
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x17210BEBu:
                    this.performer = reader.ReadStringAsUTF16String();
                    return true;
                case 0x9A984B0Du:
                    this.audio_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x0905A936u:
                    this.audio_duration = reader.ReadInt();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0x13348709u:
                    this.input_message_content = (InputMessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x13CAA7A1u)]
    public partial class InputInlineQueryResultContact
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x4C62E638u:
                    this.contact = (Contact)reader.ReadValue();
                    return true;
                case 0x815E207Bu:
                    this.thumbnail_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x4D8D948Au:
                    this.thumbnail_width = reader.ReadInt();
                    return true;
                case 0x533025B9u:
                    this.thumbnail_height = reader.ReadInt();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0x13348709u:
                    this.input_message_content = (InputMessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x51E509D7u)]
    public partial class InputInlineQueryResultDocument
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x6DE44026u:
                    this.description = reader.ReadStringAsUTF16String();
                    return true;
                case 0x27DCB74Au:
                    this.document_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2100AA2Eu:
                    this.mime_type = reader.ReadStringAsUTF16String();
                    return true;
                case 0x815E207Bu:
                    this.thumbnail_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x4D8D948Au:
                    this.thumbnail_width = reader.ReadInt();
                    return true;
                case 0x533025B9u:
                    this.thumbnail_height = reader.ReadInt();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0x13348709u:
                    this.input_message_content = (InputMessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xEB3E1164u)]
    public partial class InputInlineQueryResultGame
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0xD038777Eu:
                    this.game_short_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD7120A6Au)]
    public partial class InputInlineQueryResultLocation
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5E9E89CBu:
                    this.location = (Location)reader.ReadValue();
                    return true;
                case 0xA6EEA81Au:
                    this.live_period = reader.ReadInt();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x815E207Bu:
                    this.thumbnail_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x4D8D948Au:
                    this.thumbnail_width = reader.ReadInt();
                    return true;
                case 0x533025B9u:
                    this.thumbnail_height = reader.ReadInt();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0x13348709u:
                    this.input_message_content = (InputMessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBAAEFB72u)]
    public partial class InputInlineQueryResultPhoto
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x6DE44026u:
                    this.description = reader.ReadStringAsUTF16String();
                    return true;
                case 0x815E207Bu:
                    this.thumbnail_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x7BD27C7Au:
                    this.photo_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x364B4298u:
                    this.photo_width = reader.ReadInt();
                    return true;
                case 0xA0F29227u:
                    this.photo_height = reader.ReadInt();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0x13348709u:
                    this.input_message_content = (InputMessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD045FD64u)]
    public partial class InputInlineQueryResultSticker
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x815E207Bu:
                    this.thumbnail_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x9782864Au:
                    this.sticker_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0xB4658339u:
                    this.sticker_width = reader.ReadInt();
                    return true;
                case 0x01A12F98u:
                    this.sticker_height = reader.ReadInt();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0x13348709u:
                    this.input_message_content = (InputMessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3F886467u)]
    public partial class InputInlineQueryResultVenue
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x91911B0Du:
                    this.venue = (Venue)reader.ReadValue();
                    return true;
                case 0x815E207Bu:
                    this.thumbnail_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x4D8D948Au:
                    this.thumbnail_width = reader.ReadInt();
                    return true;
                case 0x533025B9u:
                    this.thumbnail_height = reader.ReadInt();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0x13348709u:
                    this.input_message_content = (InputMessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD2DEA546u)]
    public partial class InputInlineQueryResultVideo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x6DE44026u:
                    this.description = reader.ReadStringAsUTF16String();
                    return true;
                case 0x815E207Bu:
                    this.thumbnail_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x0EEF80AAu:
                    this.video_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2100AA2Eu:
                    this.mime_type = reader.ReadStringAsUTF16String();
                    return true;
                case 0x03784C8Du:
                    this.video_width = reader.ReadInt();
                    return true;
                case 0xCD1A45C2u:
                    this.video_height = reader.ReadInt();
                    return true;
                case 0x2EDDB27Cu:
                    this.video_duration = reader.ReadInt();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0x13348709u:
                    this.input_message_content = (InputMessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x427405D2u)]
    public partial class InputInlineQueryResultVoiceNote
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0xEDDAD34Bu:
                    this.voice_note_url = reader.ReadStringAsUTF16String();
                    return true;
                case 0xB5227B0Bu:
                    this.voice_note_duration = reader.ReadInt();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0x13348709u:
                    this.input_message_content = (InputMessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF1CBD026u)]
    public partial class InlineQueryResultArticle
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0xF47645AEu:
                    this.url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x22EC5B68u:
                    this.hide_url = reader.ReadBool();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x6DE44026u:
                    this.description = reader.ReadStringAsUTF16String();
                    return true;
                case 0xC35726E6u:
                    this.thumbnail = (PhotoSize)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBF933878u)]
    public partial class InlineQueryResultContact
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x4C62E638u:
                    this.contact = (Contact)reader.ReadValue();
                    return true;
                case 0xC35726E6u:
                    this.thumbnail = (PhotoSize)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x28B13985u)]
    public partial class InlineQueryResultLocation
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5E9E89CBu:
                    this.location = (Location)reader.ReadValue();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0xC35726E6u:
                    this.thumbnail = (PhotoSize)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8CAF42AAu)]
    public partial class InlineQueryResultVenue
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x91911B0Du:
                    this.venue = (Venue)reader.ReadValue();
                    return true;
                case 0xC35726E6u:
                    this.thumbnail = (PhotoSize)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xAA62F29Cu)]
    public partial class InlineQueryResultGame
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x232B318Cu:
                    this.game = (Game)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1C40C7FBu)]
    public partial class InlineQueryResultAnimation
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x8D5284DCu:
                    this.animation = (Animation)reader.ReadValue();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x05436F32u)]
    public partial class InlineQueryResultAudio
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x187D3695u:
                    this.audio = (Audio)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xAE463A38u)]
    public partial class InlineQueryResultDocument
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0xD8698A76u:
                    this.document = (Document)reader.ReadValue();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x6DE44026u:
                    this.description = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0989DDBFu)]
    public partial class InlineQueryResultPhoto
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x14B78418u:
                    this.photo = (Photo)reader.ReadValue();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x6DE44026u:
                    this.description = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7C1C62BDu)]
    public partial class InlineQueryResultSticker
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x8FEDBCFDu:
                    this.sticker = (Sticker)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x61F9838Bu)]
    public partial class InlineQueryResultVideo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x7CC7DA2Cu:
                    this.video = (Video)reader.ReadValue();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x6DE44026u:
                    this.description = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x723E5908u)]
    public partial class InlineQueryResultVoiceNote
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0xE27EDDCFu:
                    this.voice_note = (VoiceNote)reader.ReadValue();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0BFA4BB7u)]
    public partial class InlineQueryResults
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x975AF2A3u:
                    this.inline_query_id = reader.ReadIntegerString();
                    return true;
                case 0x00DFCF6Cu:
                    this.next_offset = reader.ReadStringAsUTF16String();
                    return true;
                case 0x9FA3E414u:
                    this.results = reader.ReadArray<InlineQueryResult>();
                    return true;
                case 0xD2D173A6u:
                    this.switch_pm_text = reader.ReadStringAsUTF16String();
                    return true;
                case 0xC96402E0u:
                    this.switch_pm_parameter = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x857F5D9Bu)]
    public partial class CallbackQueryPayloadData
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xADF3F363u:
                    this.data = reader.ReadBase64String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0BA79F74u)]
    public partial class CallbackQueryPayloadGame
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xD038777Eu:
                    this.game_short_name = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x37D44B96u)]
    public partial class CallbackQueryAnswer
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = reader.ReadStringAsUTF16String();
                    return true;
                case 0x154C221Du:
                    this.show_alert = reader.ReadBool();
                    return true;
                case 0xF47645AEu:
                    this.url = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x514BAADBu)]
    public partial class CustomRequestResult
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x136AC113u:
                    this.result = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x56AFA473u)]
    public partial class GameHighScore
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x462CE4F5u:
                    this.position = reader.ReadInt();
                    return true;
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0x32993751u:
                    this.score = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD2544029u)]
    public partial class GameHighScores
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x0750375Eu:
                    this.scores = reader.ReadArray<GameHighScore>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC00D4586u)]
    public partial class ChatEventMessageEdited
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xC528E92Fu:
                    this.old_message = (Message)reader.ReadValue();
                    return true;
                case 0x6DFE6391u:
                    this.new_message = (Message)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD557FE01u)]
    public partial class ChatEventMessageDeleted
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xB6BD307Fu:
                    this.message = (Message)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE7E00C00u)]
    public partial class ChatEventMessagePinned
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xB6BD307Fu:
                    this.message = (Message)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC6170E51u)]
    public partial class ChatEventMessageUnpinned { }
    [TLTypeHash(0x25435C5Fu)]
    public partial class ChatEventMemberJoined { }
    [TLTypeHash(0x6084000Bu)]
    public partial class ChatEventMemberLeft { }
    [TLTypeHash(0xE2004C21u)]
    public partial class ChatEventMemberInvited
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0x7B00651Cu:
                    this.status = (ChatMemberStatus)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x45625B6Fu)]
    public partial class ChatEventMemberPromoted
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0x32CFB69Bu:
                    this.old_status = (ChatMemberStatus)reader.ReadValue();
                    return true;
                case 0x839A5D36u:
                    this.new_status = (ChatMemberStatus)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x06232E0Cu)]
    public partial class ChatEventMemberRestricted
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0x32CFB69Bu:
                    this.old_status = (ChatMemberStatus)reader.ReadValue();
                    return true;
                case 0x839A5D36u:
                    this.new_status = (ChatMemberStatus)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC4D7DFC9u)]
    public partial class ChatEventTitleChanged
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8DA2B28Du:
                    this.old_title = reader.ReadStringAsUTF16String();
                    return true;
                case 0xD3A03BB6u:
                    this.new_title = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x6631E867u)]
    public partial class ChatEventDescriptionChanged
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xE18B1FE2u:
                    this.old_description = reader.ReadStringAsUTF16String();
                    return true;
                case 0xFFEBF15Eu:
                    this.new_description = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8276C22Bu)]
    public partial class ChatEventUsernameChanged
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x9346C25Au:
                    this.old_username = reader.ReadStringAsUTF16String();
                    return true;
                case 0xBF378A5Bu:
                    this.new_username = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5FC9BDC8u)]
    public partial class ChatEventPhotoChanged
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xB2234EFEu:
                    this.old_photo = (ChatPhoto)reader.ReadValue();
                    return true;
                case 0xEC21C7C5u:
                    this.new_photo = (ChatPhoto)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA3C4CB9Au)]
    public partial class ChatEventInvitesToggled
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x36BEB4E3u:
                    this.anyone_can_invite = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF8EC66A7u)]
    public partial class ChatEventSignMessagesToggled
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x18BBF871u:
                    this.sign_messages = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBC5A5D5Fu)]
    public partial class ChatEventStickerSetChanged
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x929FC4CDu:
                    this.old_sticker_set_id = reader.ReadIntegerString();
                    return true;
                case 0xD3947C9Du:
                    this.new_sticker_set_id = reader.ReadIntegerString();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5D2BFC72u)]
    public partial class ChatEventIsAllHistoryAvailableToggled
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF4846EB9u:
                    this.is_all_history_available = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x01D6C8F9u)]
    public partial class ChatEvent
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadIntegerString();
                    return true;
                case 0xAA9E377Au:
                    this.date = reader.ReadInt();
                    return true;
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0x47CC8C92u:
                    this.action = (ChatEventAction)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDF6E537Bu)]
    public partial class ChatEvents
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5387574Au:
                    this.events = reader.ReadArray<ChatEvent>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9D1D9BCCu)]
    public partial class ChatEventLogFilters
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x194BFC44u:
                    this.message_edits = reader.ReadBool();
                    return true;
                case 0x3A9EC0A3u:
                    this.message_deletions = reader.ReadBool();
                    return true;
                case 0x969A7259u:
                    this.message_pins = reader.ReadBool();
                    return true;
                case 0x61B07C57u:
                    this.member_joins = reader.ReadBool();
                    return true;
                case 0xB9902F6Cu:
                    this.member_leaves = reader.ReadBool();
                    return true;
                case 0xBC8ADDF8u:
                    this.member_invites = reader.ReadBool();
                    return true;
                case 0x01552EDDu:
                    this.member_promotions = reader.ReadBool();
                    return true;
                case 0x121B27AFu:
                    this.member_restrictions = reader.ReadBool();
                    return true;
                case 0xA2E591A3u:
                    this.info_changes = reader.ReadBool();
                    return true;
                case 0x787208D5u:
                    this.setting_changes = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2B3A21E4u)]
    public partial class LanguagePackStringValueOrdinary
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1D775834u:
                    this.value = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8E008774u)]
    public partial class LanguagePackStringValuePluralized
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA1130626u:
                    this.zero_value = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5FB19E1Bu:
                    this.one_value = reader.ReadStringAsUTF16String();
                    return true;
                case 0xB6A037F9u:
                    this.two_value = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5E39B9F1u:
                    this.few_value = reader.ReadStringAsUTF16String();
                    return true;
                case 0x1697402Bu:
                    this.many_value = reader.ReadStringAsUTF16String();
                    return true;
                case 0x75C3AF9Au:
                    this.other_value = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x666AC2B6u)]
    public partial class LanguagePackStringValueDeleted { }
    [TLTypeHash(0x657F0855u)]
    public partial class LanguagePackString
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8A90ABA9u:
                    this.key = reader.ReadStringAsUTF16String();
                    return true;
                case 0x1D775834u:
                    this.value = (LanguagePackStringValue)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x006A1578u)]
    public partial class LanguagePackStrings
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xB49A6AF5u:
                    this.strings = reader.ReadArray<LanguagePackString>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE73D270Au)]
    public partial class LanguagePackInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5E237E06u:
                    this.name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x274EC82Du:
                    this.native_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x60D09862u:
                    this.local_string_count = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x42426C88u)]
    public partial class LocalizationTargetInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xC6A66476u:
                    this.language_packs = reader.ReadArray<LanguagePackInfo>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x31A21B08u)]
    public partial class DeviceTokenGoogleCloudMessaging
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5F37A13Bu:
                    this.token = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x567D24BBu)]
    public partial class DeviceTokenApplePush
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x99B2415Cu:
                    this.device_token = reader.ReadStringAsUTF16String();
                    return true;
                case 0xDAD11C5Fu:
                    this.is_app_sandbox = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2BD7721Au)]
    public partial class DeviceTokenApplePushVoIP
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x99B2415Cu:
                    this.device_token = reader.ReadStringAsUTF16String();
                    return true;
                case 0xDAD11C5Fu:
                    this.is_app_sandbox = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x806F9D10u)]
    public partial class DeviceTokenWindowsPush
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xB6A2DD68u:
                    this.access_token = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC0ACD580u)]
    public partial class DeviceTokenMicrosoftPush
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xD9B966E5u:
                    this.channel_uri = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x39B4D672u)]
    public partial class DeviceTokenMicrosoftPushVoIP
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xD9B966E5u:
                    this.channel_uri = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD2DEA184u)]
    public partial class DeviceTokenWebPush
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xC4420F7Bu:
                    this.endpoint = reader.ReadStringAsUTF16String();
                    return true;
                case 0xE73BEEDCu:
                    this.p256dh_base64url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x53842B08u:
                    this.auth_base64url = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDDEFE862u)]
    public partial class DeviceTokenSimplePush
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xC4420F7Bu:
                    this.endpoint = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x457EDC81u)]
    public partial class DeviceTokenUbuntuPush
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5F37A13Bu:
                    this.token = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA6C43DD1u)]
    public partial class DeviceTokenBlackBerryPush
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5F37A13Bu:
                    this.token = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x27713612u)]
    public partial class DeviceTokenTizenPush
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x990B26CCu:
                    this.reg_id = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD592642Cu)]
    public partial class Wallpaper
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadInt();
                    return true;
                case 0xB69E8769u:
                    this.sizes = reader.ReadArray<PhotoSize>();
                    return true;
                case 0x665648E9u:
                    this.color = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2903318Cu)]
    public partial class Wallpapers
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2903318Cu:
                    this.wallpapers = reader.ReadArray<Wallpaper>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x21E12BEFu)]
    public partial class Hashtags
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x21E12BEFu:
                    this.hashtags = reader.ReadArray<string>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x08B0DD1Au)]
    public partial class CheckChatUsernameResultOk { }
    [TLTypeHash(0x02A0BC10u)]
    public partial class CheckChatUsernameResultUsernameInvalid { }
    [TLTypeHash(0xE77FE95Fu)]
    public partial class CheckChatUsernameResultUsernameOccupied { }
    [TLTypeHash(0x0950D8A3u)]
    public partial class CheckChatUsernameResultPublicChatsTooMuch { }
    [TLTypeHash(0x9CAD7A75u)]
    public partial class CheckChatUsernameResultPublicGroupsUnavailable { }
    [TLTypeHash(0x70F03900u)]
    public partial class OptionValueBoolean
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1D775834u:
                    this.value = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8E968B4Fu)]
    public partial class OptionValueEmpty { }
    [TLTypeHash(0xA07A1A63u)]
    public partial class OptionValueInteger
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1D775834u:
                    this.value = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE432B9B7u)]
    public partial class OptionValueString
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1D775834u:
                    this.value = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x16276ADEu)]
    public partial class UserPrivacySettingRuleAllowAll { }
    [TLTypeHash(0xFCE5477Fu)]
    public partial class UserPrivacySettingRuleAllowContacts { }
    [TLTypeHash(0xB5CB12F9u)]
    public partial class UserPrivacySettingRuleAllowUsers
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x9BCCC613u:
                    this.user_ids = reader.ReadArray<int>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x89C970D7u)]
    public partial class UserPrivacySettingRuleRestrictAll { }
    [TLTypeHash(0x9BF4F98Au)]
    public partial class UserPrivacySettingRuleRestrictContacts { }
    [TLTypeHash(0x996BCF24u)]
    public partial class UserPrivacySettingRuleRestrictUsers
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x9BCCC613u:
                    this.user_ids = reader.ReadArray<int>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5BEEFC5Au)]
    public partial class UserPrivacySettingRules
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x899A993Cu:
                    this.rules = reader.ReadArray<UserPrivacySettingRule>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0E590AA7u)]
    public partial class UserPrivacySettingShowStatus { }
    [TLTypeHash(0x7ACF0FCEu)]
    public partial class UserPrivacySettingAllowChatInvites { }
    [TLTypeHash(0xAC59A752u)]
    public partial class UserPrivacySettingAllowCalls { }
    [TLTypeHash(0x66895475u)]
    public partial class AccountTtl
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xEBE4FC66u:
                    this.days = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD044D5D4u)]
    public partial class Session
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadIntegerString();
                    return true;
                case 0xCACFB2C3u:
                    this.is_current = reader.ReadBool();
                    return true;
                case 0x54963938u:
                    this.api_id = reader.ReadInt();
                    return true;
                case 0xA9CF168Eu:
                    this.application_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x54A2D6F0u:
                    this.application_version = reader.ReadStringAsUTF16String();
                    return true;
                case 0xB149676Eu:
                    this.is_official_application = reader.ReadBool();
                    return true;
                case 0x111092BEu:
                    this.device_model = reader.ReadStringAsUTF16String();
                    return true;
                case 0x3952D0CBu:
                    this.platform = reader.ReadStringAsUTF16String();
                    return true;
                case 0x536FAF50u:
                    this.system_version = reader.ReadStringAsUTF16String();
                    return true;
                case 0xB8E83089u:
                    this.log_in_date = reader.ReadInt();
                    return true;
                case 0x04C8DAA6u:
                    this.last_active_date = reader.ReadInt();
                    return true;
                case 0xA5E3B32Du:
                    this.ip = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5373C966u:
                    this.country = reader.ReadStringAsUTF16String();
                    return true;
                case 0x0F62F176u:
                    this.region = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9A609D13u)]
    public partial class Sessions
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x9A609D13u:
                    this.sessions = reader.ReadArray<Session>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8859E775u)]
    public partial class ConnectedWebsite
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadIntegerString();
                    return true;
                case 0xF3FF5361u:
                    this.domain_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5898BEB0u:
                    this.bot_user_id = reader.ReadInt();
                    return true;
                case 0xDA130F3Au:
                    this.browser = reader.ReadStringAsUTF16String();
                    return true;
                case 0x3952D0CBu:
                    this.platform = reader.ReadStringAsUTF16String();
                    return true;
                case 0xB8E83089u:
                    this.log_in_date = reader.ReadInt();
                    return true;
                case 0x04C8DAA6u:
                    this.last_active_date = reader.ReadInt();
                    return true;
                case 0xA5E3B32Du:
                    this.ip = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5E9E89CBu:
                    this.location = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3BE9135Fu)]
    public partial class ConnectedWebsites
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2527D78Du:
                    this.websites = reader.ReadArray<ConnectedWebsite>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x50B798ABu)]
    public partial class ChatReportSpamState
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x74C9F29Bu:
                    this.can_report_spam = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xFE8EA104u)]
    public partial class ChatReportReasonSpam { }
    [TLTypeHash(0x09ECC6D3u)]
    public partial class ChatReportReasonViolence { }
    [TLTypeHash(0x3F02F332u)]
    public partial class ChatReportReasonPornography { }
    [TLTypeHash(0x85BCE10Cu)]
    public partial class ChatReportReasonCopyright { }
    [TLTypeHash(0x77D35A86u)]
    public partial class ChatReportReasonCustom
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8D854E1Bu)]
    public partial class PublicMessageLink
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x36AC99F1u:
                    this.link = reader.ReadStringAsUTF16String();
                    return true;
                case 0x1879F8E5u:
                    this.html = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x46866AFAu)]
    public partial class FileTypeNone { }
    [TLTypeHash(0xA627F635u)]
    public partial class FileTypeAnimation { }
    [TLTypeHash(0x4EF7E4DCu)]
    public partial class FileTypeAudio { }
    [TLTypeHash(0x1941F1CCu)]
    public partial class FileTypeDocument { }
    [TLTypeHash(0x423D5651u)]
    public partial class FileTypePhoto { }
    [TLTypeHash(0xA5CE2150u)]
    public partial class FileTypeProfilePhoto { }
    [TLTypeHash(0x53F49B03u)]
    public partial class FileTypeSecret { }
    [TLTypeHash(0x10EA54B4u)]
    public partial class FileTypeSecretThumbnail { }
    [TLTypeHash(0x398829E2u)]
    public partial class FileTypeSecure { }
    [TLTypeHash(0xC68BADC3u)]
    public partial class FileTypeSticker { }
    [TLTypeHash(0xE822540Fu)]
    public partial class FileTypeThumbnail { }
    [TLTypeHash(0xE440B6F9u)]
    public partial class FileTypeUnknown { }
    [TLTypeHash(0x2A4D0865u)]
    public partial class FileTypeVideo { }
    [TLTypeHash(0xF308FB3Du)]
    public partial class FileTypeVideoNote { }
    [TLTypeHash(0xC85968C6u)]
    public partial class FileTypeVoiceNote { }
    [TLTypeHash(0xFEE716C5u)]
    public partial class FileTypeWallpaper { }
    [TLTypeHash(0xB13CF94Bu)]
    public partial class StorageStatisticsByFileType
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x05223F47u:
                    this.file_type = (FileType)reader.ReadValue();
                    return true;
                case 0xF7C0246Au:
                    this.size = reader.ReadLong();
                    return true;
                case 0x85D94462u:
                    this.count = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA8454264u)]
    public partial class StorageStatisticsByChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xF7C0246Au:
                    this.size = reader.ReadLong();
                    return true;
                case 0x85D94462u:
                    this.count = reader.ReadInt();
                    return true;
                case 0x91E7AEA2u:
                    this.by_file_type = reader.ReadArray<StorageStatisticsByFileType>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x080936E0u)]
    public partial class StorageStatistics
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF7C0246Au:
                    this.size = reader.ReadLong();
                    return true;
                case 0x85D94462u:
                    this.count = reader.ReadInt();
                    return true;
                case 0x53F2AB17u:
                    this.by_chat = reader.ReadArray<StorageStatisticsByChat>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xACD40D9Bu)]
    public partial class StorageStatisticsFast
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x7008210Bu:
                    this.files_size = reader.ReadLong();
                    return true;
                case 0x2F5AF455u:
                    this.file_count = reader.ReadInt();
                    return true;
                case 0x85BD6626u:
                    this.database_size = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB95304ABu)]
    public partial class NetworkTypeNone { }
    [TLTypeHash(0x3A8F8F99u)]
    public partial class NetworkTypeMobile { }
    [TLTypeHash(0xEBA20355u)]
    public partial class NetworkTypeMobileRoaming { }
    [TLTypeHash(0xC424828Du)]
    public partial class NetworkTypeWiFi { }
    [TLTypeHash(0x93415365u)]
    public partial class NetworkTypeOther { }
    [TLTypeHash(0xA5609291u)]
    public partial class NetworkStatisticsEntryFile
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x05223F47u:
                    this.file_type = (FileType)reader.ReadValue();
                    return true;
                case 0xF783945Eu:
                    this.network_type = (NetworkType)reader.ReadValue();
                    return true;
                case 0xBF25DA46u:
                    this.sent_bytes = reader.ReadLong();
                    return true;
                case 0x74F3BEDDu:
                    this.received_bytes = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE5718BBFu)]
    public partial class NetworkStatisticsEntryCall
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF783945Eu:
                    this.network_type = (NetworkType)reader.ReadValue();
                    return true;
                case 0xBF25DA46u:
                    this.sent_bytes = reader.ReadLong();
                    return true;
                case 0x74F3BEDDu:
                    this.received_bytes = reader.ReadLong();
                    return true;
                case 0x865F80C0u:
                    this.duration = reader.ReadDouble();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x67B74906u)]
    public partial class NetworkStatistics
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x18ABAB76u:
                    this.since_date = reader.ReadInt();
                    return true;
                case 0x2DF8B3C5u:
                    this.entries = reader.ReadArray<NetworkStatisticsEntry>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x09FC50B0u)]
    public partial class ConnectionStateWaitingForNetwork { }
    [TLTypeHash(0xA4289818u)]
    public partial class ConnectionStateConnectingToProxy { }
    [TLTypeHash(0x9F061AD0u)]
    public partial class ConnectionStateConnecting { }
    [TLTypeHash(0x476C48BBu)]
    public partial class ConnectionStateUpdating { }
    [TLTypeHash(0xD593BA9Du)]
    public partial class ConnectionStateReady { }
    [TLTypeHash(0x9CFFB07Du)]
    public partial class TopChatCategoryUsers { }
    [TLTypeHash(0x05F08225u)]
    public partial class TopChatCategoryBots { }
    [TLTypeHash(0x07871238u)]
    public partial class TopChatCategoryGroups { }
    [TLTypeHash(0x67082911u)]
    public partial class TopChatCategoryChannels { }
    [TLTypeHash(0xBDA612FAu)]
    public partial class TopChatCategoryInlineBots { }
    [TLTypeHash(0x52DF491Bu)]
    public partial class TopChatCategoryCalls { }
    [TLTypeHash(0xD7A3C274u)]
    public partial class TMeUrlTypeUser
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x60924B41u)]
    public partial class TMeUrlTypeSupergroup
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x386CD096u:
                    this.supergroup_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF78F6210u)]
    public partial class TMeUrlTypeChatInvite
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xCB893157u:
                    this.info = (ChatInviteLinkInfo)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x490A8AB7u)]
    public partial class TMeUrlTypeStickerSet
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xE417C78Fu:
                    this.sticker_set_id = reader.ReadIntegerString();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBE90AFE1u)]
    public partial class TMeUrl
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF47645AEu:
                    this.url = reader.ReadStringAsUTF16String();
                    return true;
                case 0x8CDE5729u:
                    this.type = (TMeUrlType)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xCCBD8D4Au)]
    public partial class TMeUrls
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2A9437A1u:
                    this.urls = reader.ReadArray<TMeUrl>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x85D94462u)]
    public partial class Count
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x85D94462u:
                    this.count = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3B8BA7C7u)]
    public partial class Text
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2FD609E6u)]
    public partial class Seconds
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2FD609E6u:
                    this.seconds = reader.ReadDouble();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x40901014u)]
    public partial class DeepLinkInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = (FormattedText)reader.ReadValue();
                    return true;
                case 0x3D2D6B44u:
                    this.need_update_application = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x93D591A6u)]
    public partial class TextParseModeMarkdown { }
    [TLTypeHash(0xB29DF0BDu)]
    public partial class TextParseModeHTML { }
    [TLTypeHash(0x63CD9325u)]
    public partial class ProxyTypeSocks5
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF85E0677u:
                    this.username = reader.ReadStringAsUTF16String();
                    return true;
                case 0x35C246D5u:
                    this.password = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE32117D9u)]
    public partial class ProxyTypeHttp
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF85E0677u:
                    this.username = reader.ReadStringAsUTF16String();
                    return true;
                case 0x35C246D5u:
                    this.password = reader.ReadStringAsUTF16String();
                    return true;
                case 0x4173E5D7u:
                    this.http_only = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xEC974E4Cu)]
    public partial class ProxyTypeMtproto
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5CA2E8E5u:
                    this.secret = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7372C9BEu)]
    public partial class Proxy
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadInt();
                    return true;
                case 0x5A6DD5F6u:
                    this.server = reader.ReadStringAsUTF16String();
                    return true;
                case 0x43915DCCu:
                    this.port = reader.ReadInt();
                    return true;
                case 0x125F4533u:
                    this.last_used_date = reader.ReadInt();
                    return true;
                case 0x46C53D4Cu:
                    this.is_enabled = reader.ReadBool();
                    return true;
                case 0x8CDE5729u:
                    this.type = (ProxyType)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x148784BBu)]
    public partial class Proxies
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x148784BBu:
                    this.proxies = reader.ReadArray<Proxy>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x75D7EBBFu)]
    public partial class InputSticker
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xFC0EB958u:
                    this.png_sticker = (InputFile)reader.ReadValue();
                    return true;
                case 0xD36FD57Du:
                    this.emojis = reader.ReadStringAsUTF16String();
                    return true;
                case 0x357EA28Bu:
                    this.mask_position = (MaskPosition)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x817895A3u)]
    public partial class UpdateAuthorizationState
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x98A5D4EBu:
                    this.authorization_state = (AuthorizationState)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDB7DC102u)]
    public partial class UpdateNewMessage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xB6BD307Fu:
                    this.message = (Message)reader.ReadValue();
                    return true;
                case 0x5771A509u:
                    this.disable_notification = reader.ReadBool();
                    return true;
                case 0xBA891C35u:
                    this.contains_mention = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE8C53165u)]
    public partial class UpdateMessageSendAcknowledged
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2519FE3Fu)]
    public partial class UpdateMessageSendSucceeded
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xB6BD307Fu:
                    this.message = (Message)reader.ReadValue();
                    return true;
                case 0xEF592477u:
                    this.old_message_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x58998D2Fu)]
    public partial class UpdateMessageSendFailed
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xB6BD307Fu:
                    this.message = (Message)reader.ReadValue();
                    return true;
                case 0xEF592477u:
                    this.old_message_id = reader.ReadLong();
                    return true;
                case 0x3362FDA4u:
                    this.error_code = reader.ReadInt();
                    return true;
                case 0x2BF96153u:
                    this.error_message = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x122E44D7u)]
    public partial class UpdateMessageContent
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
                case 0x25866347u:
                    this.new_content = (MessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4A4CF4A0u)]
    public partial class UpdateMessageEdited
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
                case 0x1B588899u:
                    this.edit_date = reader.ReadInt();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9FF2BB5Fu)]
    public partial class UpdateMessageViews
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
                case 0x11F09C87u:
                    this.views = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x57FD5F60u)]
    public partial class UpdateMessageContentOpened
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x6F33BF3Cu)]
    public partial class UpdateMessageMentionRead
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
                case 0xE9E0195Du:
                    this.unread_mention_count = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x849D9089u)]
    public partial class UpdateNewChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x659DF2AAu:
                    this.chat = (Chat)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x79598657u)]
    public partial class UpdateChatTitle
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x46D87A24u)]
    public partial class UpdateChatPhoto
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x14B78418u:
                    this.photo = (ChatPhoto)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x82F558DBu)]
    public partial class UpdateChatLastMessage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xD0310C37u:
                    this.last_message = (Message)reader.ReadValue();
                    return true;
                case 0xF5299398u:
                    this.order = reader.ReadIntegerString();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA7466DA4u)]
    public partial class UpdateChatOrder
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xF5299398u:
                    this.order = reader.ReadIntegerString();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5E0C4361u)]
    public partial class UpdateChatIsPinned
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xB56E6838u:
                    this.is_pinned = reader.ReadBool();
                    return true;
                case 0xF5299398u:
                    this.order = reader.ReadIntegerString();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF48AF4CAu)]
    public partial class UpdateChatIsMarkedAsUnread
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x890E79B0u:
                    this.is_marked_as_unread = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA5395679u)]
    public partial class UpdateChatIsSponsored
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x1398BEB0u:
                    this.is_sponsored = reader.ReadBool();
                    return true;
                case 0xF5299398u:
                    this.order = reader.ReadIntegerString();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x6DDDF13Eu)]
    public partial class UpdateChatDefaultDisableNotification
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x420254ABu:
                    this.default_disable_notification = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x05A62E6Cu)]
    public partial class UpdateChatReadInbox
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x1123A8C1u:
                    this.last_read_inbox_message_id = reader.ReadLong();
                    return true;
                case 0xFC4DDD75u:
                    this.unread_count = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x719DC7D6u)]
    public partial class UpdateChatReadOutbox
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xF1D5DB98u:
                    this.last_read_outbox_message_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2FAD2419u)]
    public partial class UpdateChatUnreadMentionCount
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xE9E0195Du:
                    this.unread_mention_count = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xAF7363B3u)]
    public partial class UpdateChatNotificationSettings
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xB0559860u:
                    this.notification_settings = (ChatNotificationSettings)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x73516088u)]
    public partial class UpdateScopeNotificationSettings
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x00AF55D3u:
                    this.scope = (NotificationSettingsScope)reader.ReadValue();
                    return true;
                case 0xB0559860u:
                    this.notification_settings = (ScopeNotificationSettings)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xECBCB544u)]
    public partial class UpdateChatReplyMarkup
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xC37A0A68u:
                    this.reply_markup_message_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x11D83447u)]
    public partial class UpdateChatDraftMessage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x4E74485Cu:
                    this.draft_message = (DraftMessage)reader.ReadValue();
                    return true;
                case 0xF5299398u:
                    this.order = reader.ReadIntegerString();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x188F7E85u)]
    public partial class UpdateDeleteMessages
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x59EF2D74u:
                    this.message_ids = reader.ReadArray<long>();
                    return true;
                case 0xDB65ED47u:
                    this.is_permanent = reader.ReadBool();
                    return true;
                case 0x78314EF8u:
                    this.from_cache = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x244690E4u)]
    public partial class UpdateUserChatAction
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0x47CC8C92u:
                    this.action = (ChatAction)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB78260A6u)]
    public partial class UpdateUserStatus
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0x7B00651Cu:
                    this.status = (UserStatus)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB7AD1DEEu)]
    public partial class UpdateUser
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8D93D649u:
                    this.user = (User)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x06E640F9u)]
    public partial class UpdateBasicGroup
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xB7F4EA59u:
                    this.basic_group = (BasicGroup)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7FC22AFFu)]
    public partial class UpdateSupergroup
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xDC163DB7u:
                    this.supergroup = (Supergroup)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDEC7B97Au)]
    public partial class UpdateSecretChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x07B5389Fu:
                    this.secret_chat = (SecretChat)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xCABDE3FEu)]
    public partial class UpdateUserFullInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0x4E8EA171u:
                    this.user_full_info = (UserFullInfo)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB6F988B0u)]
    public partial class UpdateBasicGroupFullInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1B6DFDDBu:
                    this.basic_group_id = reader.ReadInt();
                    return true;
                case 0x771840E1u:
                    this.basic_group_full_info = (BasicGroupFullInfo)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x37AF5702u)]
    public partial class UpdateSupergroupFullInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x386CD096u:
                    this.supergroup_id = reader.ReadInt();
                    return true;
                case 0x66116BD0u:
                    this.supergroup_full_info = (SupergroupFullInfo)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE672E45Bu)]
    public partial class UpdateServiceNotification
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8CDE5729u:
                    this.type = reader.ReadStringAsUTF16String();
                    return true;
                case 0xFEC530A9u:
                    this.content = (MessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB6A1FDB7u)]
    public partial class UpdateFile
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8C9F3610u:
                    this.file = (File)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x753F1058u)]
    public partial class UpdateFileGenerationStart
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x553A6EC4u:
                    this.generation_id = reader.ReadIntegerString();
                    return true;
                case 0x0121E039u:
                    this.original_path = reader.ReadStringAsUTF16String();
                    return true;
                case 0xA8F5023Eu:
                    this.destination_path = reader.ReadStringAsUTF16String();
                    return true;
                case 0xBD912744u:
                    this.conversion = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2A54F832u)]
    public partial class UpdateFileGenerationStop
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x553A6EC4u:
                    this.generation_id = reader.ReadIntegerString();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF6B0E499u)]
    public partial class UpdateCall
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xCC8E2F3Eu:
                    this.call = (Call)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x39099004u)]
    public partial class UpdateUserPrivacySettingRules
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x9F74B898u:
                    this.setting = (UserPrivacySetting)reader.ReadValue();
                    return true;
                case 0x899A993Cu:
                    this.rules = (UserPrivacySettingRules)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBBCA7BABu)]
    public partial class UpdateUnreadMessageCount
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xFC4DDD75u:
                    this.unread_count = reader.ReadInt();
                    return true;
                case 0x6869237Bu:
                    this.unread_unmuted_count = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF7FF9C15u)]
    public partial class UpdateUnreadChatCount
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xFC4DDD75u:
                    this.unread_count = reader.ReadInt();
                    return true;
                case 0x6869237Bu:
                    this.unread_unmuted_count = reader.ReadInt();
                    return true;
                case 0xA17091D4u:
                    this.marked_as_unread_count = reader.ReadInt();
                    return true;
                case 0xF542C46Du:
                    this.marked_as_unread_unmuted_count = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB7760B98u)]
    public partial class UpdateOption
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5E237E06u:
                    this.name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x1D775834u:
                    this.value = (OptionValue)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5B6FAD44u)]
    public partial class UpdateInstalledStickerSets
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x71547314u:
                    this.is_masks = reader.ReadBool();
                    return true;
                case 0x66ED467Du:
                    this.sticker_set_ids = reader.ReadArray<long>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7F878AAFu)]
    public partial class UpdateTrendingStickerSets
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x33899773u:
                    this.sticker_sets = (StickerSets)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7CD363BDu)]
    public partial class UpdateRecentStickers
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xFD0E148Cu:
                    this.is_attached = reader.ReadBool();
                    return true;
                case 0x132E647Cu:
                    this.sticker_ids = reader.ReadArray<int>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4B248F37u)]
    public partial class UpdateFavoriteStickers
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x132E647Cu:
                    this.sticker_ids = reader.ReadArray<int>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x091BE628u)]
    public partial class UpdateSavedAnimations
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xAC8BCB54u:
                    this.animation_ids = reader.ReadArray<int>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD35AC843u)]
    public partial class UpdateLanguagePackStrings
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xE6317C0Du:
                    this.localization_target = reader.ReadStringAsUTF16String();
                    return true;
                case 0xBDD46543u:
                    this.language_pack_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0xB49A6AF5u:
                    this.strings = reader.ReadArray<LanguagePackString>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x538084B6u)]
    public partial class UpdateConnectionState
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA393D2FBu:
                    this.state = (ConnectionState)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x364AF8AFu)]
    public partial class UpdateTermsOfService
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA5DEBC29u:
                    this.terms_of_service_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x937BFB98u:
                    this.terms_of_service = (TermsOfService)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8F878B1Cu)]
    public partial class UpdateNewInlineQuery
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadIntegerString();
                    return true;
                case 0x2A98155Eu:
                    this.sender_user_id = reader.ReadInt();
                    return true;
                case 0xBE136DCBu:
                    this.user_location = (Location)reader.ReadValue();
                    return true;
                case 0x24BDB5EBu:
                    this.query = reader.ReadStringAsUTF16String();
                    return true;
                case 0x590ACAD0u:
                    this.offset = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB7CBB64Fu)]
    public partial class UpdateNewChosenInlineResult
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2A98155Eu:
                    this.sender_user_id = reader.ReadInt();
                    return true;
                case 0xBE136DCBu:
                    this.user_location = (Location)reader.ReadValue();
                    return true;
                case 0x24BDB5EBu:
                    this.query = reader.ReadStringAsUTF16String();
                    return true;
                case 0x07A7B643u:
                    this.result_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0xF86D5A67u:
                    this.inline_message_id = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xFFE22CE7u)]
    public partial class UpdateNewCallbackQuery
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadIntegerString();
                    return true;
                case 0x2A98155Eu:
                    this.sender_user_id = reader.ReadInt();
                    return true;
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
                case 0x761266EEu:
                    this.chat_instance = reader.ReadIntegerString();
                    return true;
                case 0x422C6A15u:
                    this.payload = (CallbackQueryPayload)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA4ACB470u)]
    public partial class UpdateNewInlineCallbackQuery
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadIntegerString();
                    return true;
                case 0x2A98155Eu:
                    this.sender_user_id = reader.ReadInt();
                    return true;
                case 0xF86D5A67u:
                    this.inline_message_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x761266EEu:
                    this.chat_instance = reader.ReadIntegerString();
                    return true;
                case 0x422C6A15u:
                    this.payload = (CallbackQueryPayload)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDD4FAD71u)]
    public partial class UpdateNewShippingQuery
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadIntegerString();
                    return true;
                case 0x2A98155Eu:
                    this.sender_user_id = reader.ReadInt();
                    return true;
                case 0xB0F55CC6u:
                    this.invoice_payload = reader.ReadStringAsUTF16String();
                    return true;
                case 0xEB066945u:
                    this.shipping_address = (Address)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3029D331u)]
    public partial class UpdateNewPreCheckoutQuery
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadIntegerString();
                    return true;
                case 0x2A98155Eu:
                    this.sender_user_id = reader.ReadInt();
                    return true;
                case 0x6956883Fu:
                    this.currency = reader.ReadStringAsUTF16String();
                    return true;
                case 0x46B55354u:
                    this.total_amount = reader.ReadLong();
                    return true;
                case 0xB0F55CC6u:
                    this.invoice_payload = reader.ReadBase64String();
                    return true;
                case 0xE1314C58u:
                    this.shipping_option_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x86780B40u:
                    this.order_info = (OrderInfo)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x73963648u)]
    public partial class UpdateNewCustomEvent
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3BAE0AA7u:
                    this.@event = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x6C858904u)]
    public partial class UpdateNewCustomQuery
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBF396750u:
                    this.id = reader.ReadIntegerString();
                    return true;
                case 0xADF3F363u:
                    this.data = reader.ReadStringAsUTF16String();
                    return true;
                case 0x81417592u:
                    this.timeout = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x54005D38u)]
    public partial class TestInt
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1D775834u:
                    this.value = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x18F4FD08u)]
    public partial class TestString
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1D775834u:
                    this.value = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2804361Eu)]
    public partial class TestBytes
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1D775834u:
                    this.value = reader.ReadBase64String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE70D18DCu)]
    public partial class TestVectorInt
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1D775834u:
                    this.value = reader.ReadArray<int>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC4AAB035u)]
    public partial class TestVectorIntObject
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1D775834u:
                    this.value = reader.ReadArray<TestInt>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x45A0423Au)]
    public partial class TestVectorString
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1D775834u:
                    this.value = reader.ReadArray<string>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x13E9D716u)]
    public partial class TestVectorStringObject
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1D775834u:
                    this.value = reader.ReadArray<TestString>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x83EE8595u)]
    public partial class GetAuthorizationState { }
    [TLTypeHash(0xDA337A85u)]
    public partial class SetTdlibParameters
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x069348FEu:
                    this.parameters = (TdlibParameters)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB89ED3E7u)]
    public partial class CheckDatabaseEncryptionKey
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2186F990u:
                    this.encryption_key = reader.ReadBase64String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x16C806F8u)]
    public partial class SetAuthenticationPhoneNumber
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x6B01BC5Bu:
                    this.phone_number = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5C27A2A9u:
                    this.allow_flash_call = reader.ReadBool();
                    return true;
                case 0x546E8725u:
                    this.is_current_phone_number = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x14738956u)]
    public partial class ResendAuthenticationCode { }
    [TLTypeHash(0x8A80F3D7u)]
    public partial class CheckAuthenticationCode
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x77153098u:
                    this.code = reader.ReadStringAsUTF16String();
                    return true;
                case 0xA9D1C132u:
                    this.first_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0xC808BA5Au:
                    this.last_name = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xAA66D659u)]
    public partial class CheckAuthenticationPassword
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x35C246D5u:
                    this.password = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x227BCF4Au)]
    public partial class RequestAuthenticationPasswordRecovery { }
    [TLTypeHash(0x98C02661u)]
    public partial class RecoverAuthenticationPassword
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2C8D0584u:
                    this.recovery_code = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDDD1E2DAu)]
    public partial class CheckAuthenticationBotToken
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5F37A13Bu:
                    this.token = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0D81B3CFu)]
    public partial class LogOut { }
    [TLTypeHash(0x130181C4u)]
    public partial class Close { }
    [TLTypeHash(0x7C4A867Bu)]
    public partial class Destroy { }
    [TLTypeHash(0x7D12D61Bu)]
    public partial class SetDatabaseEncryptionKey
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x16054282u:
                    this.new_encryption_key = reader.ReadBase64String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBB517E49u)]
    public partial class GetPasswordState { }
    [TLTypeHash(0x3F502319u)]
    public partial class SetPassword
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5EDA82F8u:
                    this.old_password = reader.ReadStringAsUTF16String();
                    return true;
                case 0x72ABCAF9u:
                    this.new_password = reader.ReadStringAsUTF16String();
                    return true;
                case 0xC02BB78Eu:
                    this.new_hint = reader.ReadStringAsUTF16String();
                    return true;
                case 0x701CEB14u:
                    this.set_recovery_email_address = reader.ReadBool();
                    return true;
                case 0x1AF004B1u:
                    this.new_recovery_email_address = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2C16D5C0u)]
    public partial class GetRecoveryEmailAddress
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x35C246D5u:
                    this.password = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2D38F21Fu)]
    public partial class SetRecoveryEmailAddress
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x35C246D5u:
                    this.password = reader.ReadStringAsUTF16String();
                    return true;
                case 0x1AF004B1u:
                    this.new_recovery_email_address = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0F4E9624u)]
    public partial class RequestPasswordRecovery { }
    [TLTypeHash(0xCE128B4Au)]
    public partial class RecoverPassword
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2C8D0584u:
                    this.recovery_code = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA9389664u)]
    public partial class CreateTemporaryPassword
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x35C246D5u:
                    this.password = reader.ReadStringAsUTF16String();
                    return true;
                case 0xF5F46844u:
                    this.valid_for = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE7E326B4u)]
    public partial class GetTemporaryPasswordState { }
    [TLTypeHash(0x60D0EF43u)]
    public partial class ProcessDcUpdate
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x94F38CBEu:
                    this.dc = reader.ReadStringAsUTF16String();
                    return true;
                case 0x529A9235u:
                    this.addr = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xCA3F3F62u)]
    public partial class GetMe { }
    [TLTypeHash(0x8BF3D398u)]
    public partial class GetUser
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x6EF5A33Fu)]
    public partial class GetUserFullInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8B1B9CFAu)]
    public partial class GetBasicGroup
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1B6DFDDBu:
                    this.basic_group_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB46F9886u)]
    public partial class GetBasicGroupFullInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1B6DFDDBu:
                    this.basic_group_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF23FF6FCu)]
    public partial class GetSupergroup
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x386CD096u:
                    this.supergroup_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x35394734u)]
    public partial class GetSupergroupFullInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x386CD096u:
                    this.supergroup_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x533A6579u)]
    public partial class GetSecretChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3C9AC102u:
                    this.secret_chat_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x63FDF77Bu)]
    public partial class GetChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0A33FA63u)]
    public partial class GetMessage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7556455Du)]
    public partial class GetRepliedMessage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xCD1F4304u)]
    public partial class GetChatPinnedMessage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xCFBFCC13u)]
    public partial class GetMessages
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x59EF2D74u:
                    this.message_ids = reader.ReadArray<long>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8AFF33C1u)]
    public partial class GetFile
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x93CB796Cu:
                    this.file_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD3734ACDu)]
    public partial class GetRemoteFile
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xD740CE0Bu:
                    this.remote_file_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x05223F47u:
                    this.file_type = (FileType)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDCBA9A48u)]
    public partial class GetChats
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xC25A660Au:
                    this.offset_order = reader.ReadIntegerString();
                    return true;
                case 0x943AA85Du:
                    this.offset_chat_id = reader.ReadLong();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDD7789C1u)]
    public partial class SearchPublicChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF85E0677u:
                    this.username = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF7B04AA4u)]
    public partial class SearchPublicChats
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x24BDB5EBu:
                    this.query = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xEA965279u)]
    public partial class SearchChats
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x24BDB5EBu:
                    this.query = reader.ReadStringAsUTF16String();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0C1B11F6u)]
    public partial class SearchChatsOnServer
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x24BDB5EBu:
                    this.query = reader.ReadStringAsUTF16String();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x05D2635Du)]
    public partial class GetTopChats
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x064C19C1u:
                    this.category = (TopChatCategory)reader.ReadValue();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF632167Bu)]
    public partial class RemoveTopChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x064C19C1u:
                    this.category = (TopChatCategory)reader.ReadValue();
                    return true;
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8E40E6AEu)]
    public partial class AddRecentlyFoundChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4B0279A9u)]
    public partial class RemoveRecentlyFoundChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x785E2CE1u)]
    public partial class ClearRecentlyFoundChats { }
    [TLTypeHash(0x91778F3Au)]
    public partial class CheckChatUsername
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadIntegerString();
                    return true;
                case 0xF85E0677u:
                    this.username = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x6A3DA39Eu)]
    public partial class GetCreatedPublicChats { }
    [TLTypeHash(0xFF71ECA2u)]
    public partial class GetGroupsInCommon
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0x943AA85Du:
                    this.offset_chat_id = reader.ReadLong();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x97C828A6u)]
    public partial class GetChatHistory
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x78DED52Eu:
                    this.from_message_id = reader.ReadLong();
                    return true;
                case 0x590ACAD0u:
                    this.offset = reader.ReadInt();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
                case 0x195F8866u:
                    this.only_local = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD4E076EAu)]
    public partial class DeleteChatHistory
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xBD6A7F6Bu:
                    this.remove_from_chat_list = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x27D7A54Cu)]
    public partial class SearchChatMessages
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x24BDB5EBu:
                    this.query = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2A98155Eu:
                    this.sender_user_id = reader.ReadInt();
                    return true;
                case 0x78DED52Eu:
                    this.from_message_id = reader.ReadLong();
                    return true;
                case 0x590ACAD0u:
                    this.offset = reader.ReadInt();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
                case 0x7FC45F1Du:
                    this.filter = (SearchMessagesFilter)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDBED7227u)]
    public partial class SearchMessages
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x24BDB5EBu:
                    this.query = reader.ReadStringAsUTF16String();
                    return true;
                case 0x01505591u:
                    this.offset_date = reader.ReadInt();
                    return true;
                case 0x943AA85Du:
                    this.offset_chat_id = reader.ReadLong();
                    return true;
                case 0x8FB4F7F1u:
                    this.offset_message_id = reader.ReadLong();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x73742668u)]
    public partial class SearchSecretMessages
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x24BDB5EBu:
                    this.query = reader.ReadStringAsUTF16String();
                    return true;
                case 0x759BF513u:
                    this.from_search_id = reader.ReadIntegerString();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
                case 0x7FC45F1Du:
                    this.filter = (SearchMessagesFilter)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBE7CF010u)]
    public partial class SearchCallMessages
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x78DED52Eu:
                    this.from_message_id = reader.ReadLong();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
                case 0xE6706CE4u:
                    this.only_missed = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8D0A7504u)]
    public partial class SearchChatRecentLocationMessages
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4C6B3CBFu)]
    public partial class GetActiveLiveLocationMessages { }
    [TLTypeHash(0xFF37C604u)]
    public partial class GetChatMessageByDate
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xAA9E377Au:
                    this.date = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDDE5B601u)]
    public partial class GetChatMessageCount
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x7FC45F1Du:
                    this.filter = (SearchMessagesFilter)reader.ReadValue();
                    return true;
                case 0x52612484u:
                    this.return_local = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3C9A1497u)]
    public partial class GetPublicMessageLink
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
                case 0xB92EBCE9u:
                    this.for_album = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1FE568C0u)]
    public partial class SendMessage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x5518525Du:
                    this.reply_to_message_id = reader.ReadLong();
                    return true;
                case 0x5771A509u:
                    this.disable_notification = reader.ReadBool();
                    return true;
                case 0x97CC7257u:
                    this.from_background = reader.ReadBool();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0x13348709u:
                    this.input_message_content = (InputMessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8DAD6AA5u)]
    public partial class SendMessageAlbum
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x5518525Du:
                    this.reply_to_message_id = reader.ReadLong();
                    return true;
                case 0x5771A509u:
                    this.disable_notification = reader.ReadBool();
                    return true;
                case 0x97CC7257u:
                    this.from_background = reader.ReadBool();
                    return true;
                case 0x62C14328u:
                    this.input_message_contents = reader.ReadArray<InputMessageContent>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3671AA99u)]
    public partial class SendBotStartMessage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5898BEB0u:
                    this.bot_user_id = reader.ReadInt();
                    return true;
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x2A979110u:
                    this.parameter = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1AABAA61u)]
    public partial class SendInlineQueryResultMessage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x5518525Du:
                    this.reply_to_message_id = reader.ReadLong();
                    return true;
                case 0x5771A509u:
                    this.disable_notification = reader.ReadBool();
                    return true;
                case 0x97CC7257u:
                    this.from_background = reader.ReadBool();
                    return true;
                case 0xEF946F99u:
                    this.query_id = reader.ReadIntegerString();
                    return true;
                case 0x07A7B643u:
                    this.result_id = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC21B67C1u)]
    public partial class ForwardMessages
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x9CC4928Au:
                    this.from_chat_id = reader.ReadLong();
                    return true;
                case 0x59EF2D74u:
                    this.message_ids = reader.ReadArray<long>();
                    return true;
                case 0x5771A509u:
                    this.disable_notification = reader.ReadBool();
                    return true;
                case 0x97CC7257u:
                    this.from_background = reader.ReadBool();
                    return true;
                case 0xA6819686u:
                    this.as_album = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7D91B6EAu)]
    public partial class SendChatSetTtlMessage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xA3EE881Fu:
                    this.ttl = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD1A683D7u)]
    public partial class SendChatScreenshotTakenNotification
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9388FC64u)]
    public partial class AddLocalMessage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x2A98155Eu:
                    this.sender_user_id = reader.ReadInt();
                    return true;
                case 0x5518525Du:
                    this.reply_to_message_id = reader.ReadLong();
                    return true;
                case 0x5771A509u:
                    this.disable_notification = reader.ReadBool();
                    return true;
                case 0x13348709u:
                    this.input_message_content = (InputMessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF5CD49EBu)]
    public partial class DeleteMessages
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x59EF2D74u:
                    this.message_ids = reader.ReadArray<long>();
                    return true;
                case 0x10F4A1B2u:
                    this.revoke = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x29328AD9u)]
    public partial class DeleteChatMessagesFromUser
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8FCD3754u)]
    public partial class EditMessageText
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0x13348709u:
                    this.input_message_content = (InputMessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x20FCC810u)]
    public partial class EditMessageLiveLocation
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0x5E9E89CBu:
                    this.location = (Location)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x039E2562u)]
    public partial class EditMessageMedia
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0x13348709u:
                    this.input_message_content = (InputMessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE7D721C7u)]
    public partial class EditMessageCaption
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0xF67C4965u:
                    this.caption = (FormattedText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE2988FE3u)]
    public partial class EditMessageReplyMarkup
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xEF831B25u)]
    public partial class EditInlineMessageText
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF86D5A67u:
                    this.inline_message_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0x13348709u:
                    this.input_message_content = (InputMessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE47B16A7u)]
    public partial class EditInlineMessageLiveLocation
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF86D5A67u:
                    this.inline_message_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0x5E9E89CBu:
                    this.location = (Location)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x24FC2AE4u)]
    public partial class EditInlineMessageMedia
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF86D5A67u:
                    this.inline_message_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0x13348709u:
                    this.input_message_content = (InputMessageContent)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1AB124F9u)]
    public partial class EditInlineMessageCaption
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF86D5A67u:
                    this.inline_message_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
                case 0xF67C4965u:
                    this.caption = (FormattedText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x040C801Au)]
    public partial class EditInlineMessageReplyMarkup
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF86D5A67u:
                    this.inline_message_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x2F7AF593u:
                    this.reply_markup = (ReplyMarkup)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE6486B2Eu)]
    public partial class GetTextEntities
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8BED6250u)]
    public partial class ParseTextEntities
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = reader.ReadStringAsUTF16String();
                    return true;
                case 0x39DA7A16u:
                    this.parse_mode = (TextParseMode)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x11913948u)]
    public partial class GetFileMimeType
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xD7DF1668u:
                    this.file_name = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x94A581CFu)]
    public partial class GetFileExtension
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2100AA2Eu:
                    this.mime_type = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1A7F25FDu)]
    public partial class CleanFileName
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xD7DF1668u:
                    this.file_name = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x81C0D804u)]
    public partial class GetLanguagePackString
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xC394DA75u:
                    this.language_pack_database_path = reader.ReadStringAsUTF16String();
                    return true;
                case 0xE6317C0Du:
                    this.localization_target = reader.ReadStringAsUTF16String();
                    return true;
                case 0xBDD46543u:
                    this.language_pack_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x8A90ABA9u:
                    this.key = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xEF459BE6u)]
    public partial class GetInlineQueryResults
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5898BEB0u:
                    this.bot_user_id = reader.ReadInt();
                    return true;
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xBE136DCBu:
                    this.user_location = (Location)reader.ReadValue();
                    return true;
                case 0x24BDB5EBu:
                    this.query = reader.ReadStringAsUTF16String();
                    return true;
                case 0x590ACAD0u:
                    this.offset = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD077D780u)]
    public partial class AnswerInlineQuery
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x975AF2A3u:
                    this.inline_query_id = reader.ReadIntegerString();
                    return true;
                case 0x64231B80u:
                    this.is_personal = reader.ReadBool();
                    return true;
                case 0x9FA3E414u:
                    this.results = reader.ReadArray<InputInlineQueryResult>();
                    return true;
                case 0xD8D56692u:
                    this.cache_time = reader.ReadInt();
                    return true;
                case 0x00DFCF6Cu:
                    this.next_offset = reader.ReadStringAsUTF16String();
                    return true;
                case 0xD2D173A6u:
                    this.switch_pm_text = reader.ReadStringAsUTF16String();
                    return true;
                case 0xC96402E0u:
                    this.switch_pm_parameter = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2B5C9524u)]
    public partial class GetCallbackQueryAnswer
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
                case 0x422C6A15u:
                    this.payload = (CallbackQueryPayload)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x40CBABDEu)]
    public partial class AnswerCallbackQuery
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xC56E6DB9u:
                    this.callback_query_id = reader.ReadIntegerString();
                    return true;
                case 0x3B8BA7C7u:
                    this.text = reader.ReadStringAsUTF16String();
                    return true;
                case 0x154C221Du:
                    this.show_alert = reader.ReadBool();
                    return true;
                case 0xF47645AEu:
                    this.url = reader.ReadStringAsUTF16String();
                    return true;
                case 0xD8D56692u:
                    this.cache_time = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x62662A48u)]
    public partial class AnswerShippingQuery
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x737B2136u:
                    this.shipping_query_id = reader.ReadIntegerString();
                    return true;
                case 0x367DFC43u:
                    this.shipping_options = reader.ReadArray<ShippingOption>();
                    return true;
                case 0x2BF96153u:
                    this.error_message = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2DE39B71u)]
    public partial class AnswerPreCheckoutQuery
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x54CC3134u:
                    this.pre_checkout_query_id = reader.ReadIntegerString();
                    return true;
                case 0x2BF96153u:
                    this.error_message = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD7B0189Cu)]
    public partial class SetGameScore
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
                case 0x0C438BC5u:
                    this.edit_message = reader.ReadBool();
                    return true;
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0x32993751u:
                    this.score = reader.ReadInt();
                    return true;
                case 0x97688328u:
                    this.force = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0668A199u)]
    public partial class SetInlineGameScore
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF86D5A67u:
                    this.inline_message_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x0C438BC5u:
                    this.edit_message = reader.ReadBool();
                    return true;
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0x32993751u:
                    this.score = reader.ReadInt();
                    return true;
                case 0x97688328u:
                    this.force = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9B2B7490u)]
    public partial class GetGameHighScores
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4D7FF34Bu)]
    public partial class GetInlineGameHighScores
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF86D5A67u:
                    this.inline_message_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF1C7958Fu)]
    public partial class DeleteChatReplyMarkup
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x12F53FBDu)]
    public partial class SendChatAction
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x47CC8C92u:
                    this.action = (ChatAction)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1A516818u)]
    public partial class OpenChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x41D225EDu)]
    public partial class CloseChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7F618847u)]
    public partial class ViewMessages
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x59EF2D74u:
                    this.message_ids = reader.ReadArray<long>();
                    return true;
                case 0xB3EBCA29u:
                    this.force_read = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1DFD12A7u)]
    public partial class OpenMessageContent
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD1FC66ECu)]
    public partial class ReadAllChatMentions
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0337A62Au)]
    public partial class CreatePrivateChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0x97688328u:
                    this.force = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x501FFEC6u)]
    public partial class CreateBasicGroupChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1B6DFDDBu:
                    this.basic_group_id = reader.ReadInt();
                    return true;
                case 0x97688328u:
                    this.force = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE805C7D2u)]
    public partial class CreateSupergroupChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x386CD096u:
                    this.supergroup_id = reader.ReadInt();
                    return true;
                case 0x97688328u:
                    this.force = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5EF8BEE7u)]
    public partial class CreateSecretChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3C9AC102u:
                    this.secret_chat_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x6C444D32u)]
    public partial class CreateNewBasicGroupChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x9BCCC613u:
                    this.user_ids = reader.ReadArray<int>();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD45E7426u)]
    public partial class CreateNewSupergroupChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0xB4C5088Fu:
                    this.is_channel = reader.ReadBool();
                    return true;
                case 0x6DE44026u:
                    this.description = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBB15D7C9u)]
    public partial class CreateNewSecretChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA2D705C0u)]
    public partial class UpgradeBasicGroupChatToSupergroupChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8396A6CBu)]
    public partial class SetChatTitle
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBC175AB8u)]
    public partial class SetChatPhoto
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x14B78418u:
                    this.photo = (InputFile)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBC82A4F0u)]
    public partial class SetChatDraftMessage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x4E74485Cu:
                    this.draft_message = (DraftMessage)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB92ABA87u)]
    public partial class SetChatNotificationSettings
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xB0559860u:
                    this.notification_settings = (ChatNotificationSettings)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3E541D72u)]
    public partial class ToggleChatIsPinned
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xB56E6838u:
                    this.is_pinned = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0CBBAD3Fu)]
    public partial class ToggleChatIsMarkedAsUnread
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x890E79B0u:
                    this.is_marked_as_unread = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5BBF6693u)]
    public partial class ToggleChatDefaultDisableNotification
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x420254ABu:
                    this.default_disable_notification = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x6E04ECBEu)]
    public partial class SetChatClientData
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x7C6F3001u:
                    this.client_data = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB4E54A20u)]
    public partial class JoinChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x81D61BF9u)]
    public partial class LeaveChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4792627Bu)]
    public partial class AddChatMember
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0xD7870B08u:
                    this.forward_limit = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDC9EF5DDu)]
    public partial class AddChatMembers
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x9BCCC613u:
                    this.user_ids = reader.ReadArray<int>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x03D21908u)]
    public partial class SetChatMemberStatus
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0x7B00651Cu:
                    this.status = (ChatMemberStatus)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD2243502u)]
    public partial class GetChatMember
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x299374A4u)]
    public partial class SearchChatMembers
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x24BDB5EBu:
                    this.query = reader.ReadStringAsUTF16String();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
                case 0x7FC45F1Du:
                    this.filter = (ChatMembersFilter)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1BF0C117u)]
    public partial class GetChatAdministrators
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7B1CA8B5u)]
    public partial class ClearAllDraftMessages
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xDA115257u:
                    this.exclude_secret_chats = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4F7BE840u)]
    public partial class GetScopeNotificationSettings
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x00AF55D3u:
                    this.scope = (NotificationSettingsScope)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x52F3CDE4u)]
    public partial class SetScopeNotificationSettings
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x00AF55D3u:
                    this.scope = (NotificationSettingsScope)reader.ReadValue();
                    return true;
                case 0xB0559860u:
                    this.notification_settings = (ScopeNotificationSettings)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5FBF4EECu)]
    public partial class ResetAllNotificationSettings { }
    [TLTypeHash(0x17C9C8A6u)]
    public partial class SetPinnedChats
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5010813Du:
                    this.chat_ids = reader.ReadArray<long>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4BD0F589u)]
    public partial class DownloadFile
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x93CB796Cu:
                    this.file_id = reader.ReadInt();
                    return true;
                case 0x62A6DC27u:
                    this.priority = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x6096787Bu)]
    public partial class CancelDownloadFile
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x93CB796Cu:
                    this.file_id = reader.ReadInt();
                    return true;
                case 0x87FB3D2Bu:
                    this.only_if_pending = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5B0027C7u)]
    public partial class UploadFile
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8C9F3610u:
                    this.file = (InputFile)reader.ReadValue();
                    return true;
                case 0x05223F47u:
                    this.file_type = (FileType)reader.ReadValue();
                    return true;
                case 0x62A6DC27u:
                    this.priority = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xEE60D394u)]
    public partial class CancelUploadFile
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x93CB796Cu:
                    this.file_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1BAFABD4u)]
    public partial class SetFileGenerationProgress
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x553A6EC4u:
                    this.generation_id = reader.ReadIntegerString();
                    return true;
                case 0x9CDAEA6Bu:
                    this.expected_size = reader.ReadInt();
                    return true;
                case 0x99F88C35u:
                    this.local_prefix_size = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC5A606BEu)]
    public partial class FinishFileGeneration
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x553A6EC4u:
                    this.generation_id = reader.ReadIntegerString();
                    return true;
                case 0x5DDDBC71u:
                    this.error = (Error)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBF302FF9u)]
    public partial class DeleteFile
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x93CB796Cu:
                    this.file_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2040796Fu)]
    public partial class GenerateChatInviteLink
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x89C0B107u)]
    public partial class CheckChatInviteLink
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2E98587Bu:
                    this.invite_link = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3ED3F705u)]
    public partial class JoinChatByInviteLink
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2E98587Bu:
                    this.invite_link = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3E5C3D2Eu)]
    public partial class CreateCall
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0xC8C0BC4Cu:
                    this.protocol = (CallProtocol)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x75236A91u)]
    public partial class AcceptCall
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x50A89B2Cu:
                    this.call_id = reader.ReadInt();
                    return true;
                case 0xC8C0BC4Cu:
                    this.protocol = (CallProtocol)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7B5346AEu)]
    public partial class DiscardCall
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x50A89B2Cu:
                    this.call_id = reader.ReadInt();
                    return true;
                case 0xBA66E8FBu:
                    this.is_disconnected = reader.ReadBool();
                    return true;
                case 0x865F80C0u:
                    this.duration = reader.ReadInt();
                    return true;
                case 0x0DD03F01u:
                    this.connection_id = reader.ReadIntegerString();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xEE27E42Eu)]
    public partial class SendCallRating
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x50A89B2Cu:
                    this.call_id = reader.ReadInt();
                    return true;
                case 0xD8892622u:
                    this.rating = reader.ReadInt();
                    return true;
                case 0x9474526Cu:
                    this.comment = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDACBF887u)]
    public partial class SendCallDebugInformation
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x50A89B2Cu:
                    this.call_id = reader.ReadInt();
                    return true;
                case 0x71FF48A3u:
                    this.debug_information = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0241A9B7u)]
    public partial class BlockUser
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xCF94C687u)]
    public partial class UnblockUser
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x6B419E57u)]
    public partial class GetBlockedUsers
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x590ACAD0u:
                    this.offset = reader.ReadInt();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xAD6E3FB4u)]
    public partial class ImportContacts
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x33401573u:
                    this.contacts = reader.ReadArray<Contact>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x27FDC7F6u)]
    public partial class GetContacts { }
    [TLTypeHash(0x33AF79C2u)]
    public partial class SearchContacts
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x24BDB5EBu:
                    this.query = reader.ReadStringAsUTF16String();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xFE00F102u)]
    public partial class RemoveContacts
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x9BCCC613u:
                    this.user_ids = reader.ReadArray<int>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9D42DAA6u)]
    public partial class GetImportedContactCount { }
    [TLTypeHash(0x30610893u)]
    public partial class ChangeImportedContacts
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x33401573u:
                    this.contacts = reader.ReadArray<Contact>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD9102F1Bu)]
    public partial class ClearImportedContacts { }
    [TLTypeHash(0xAAC09973u)]
    public partial class GetUserProfilePhotos
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0x590ACAD0u:
                    this.offset = reader.ReadInt();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xCC307E93u)]
    public partial class GetStickers
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xB64BF632u:
                    this.emoji = reader.ReadStringAsUTF16String();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD862C0A7u)]
    public partial class SearchStickers
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xB64BF632u:
                    this.emoji = reader.ReadStringAsUTF16String();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xCFC42EC3u)]
    public partial class GetInstalledStickerSets
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x71547314u:
                    this.is_masks = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x352D76BFu)]
    public partial class GetArchivedStickerSets
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x71547314u:
                    this.is_masks = reader.ReadBool();
                    return true;
                case 0x73004ABAu:
                    this.offset_sticker_set_id = reader.ReadIntegerString();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB03F8926u)]
    public partial class GetTrendingStickerSets { }
    [TLTypeHash(0x1BCF3528u)]
    public partial class GetAttachedStickerSets
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x93CB796Cu:
                    this.file_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDBA7370Au)]
    public partial class GetStickerSet
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x10FB0D18u:
                    this.set_id = reader.ReadIntegerString();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4C544E24u)]
    public partial class SearchStickerSet
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5E237E06u:
                    this.name = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x99DB3335u)]
    public partial class SearchInstalledStickerSets
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x71547314u:
                    this.is_masks = reader.ReadBool();
                    return true;
                case 0x24BDB5EBu:
                    this.query = reader.ReadStringAsUTF16String();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x27417F94u)]
    public partial class SearchStickerSets
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x24BDB5EBu:
                    this.query = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB0526BEFu)]
    public partial class ChangeStickerSet
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x10FB0D18u:
                    this.set_id = reader.ReadIntegerString();
                    return true;
                case 0x5F596777u:
                    this.is_installed = reader.ReadBool();
                    return true;
                case 0xF4181FFAu:
                    this.is_archived = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE53ACC56u)]
    public partial class ViewTrendingStickerSets
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x66ED467Du:
                    this.sticker_set_ids = reader.ReadArray<long>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xAB64EEBBu)]
    public partial class ReorderInstalledStickerSets
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x71547314u:
                    this.is_masks = reader.ReadBool();
                    return true;
                case 0x66ED467Du:
                    this.sticker_set_ids = reader.ReadArray<long>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD8EE606Au)]
    public partial class GetRecentStickers
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xFD0E148Cu:
                    this.is_attached = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x60F94E9Du)]
    public partial class AddRecentSticker
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xFD0E148Cu:
                    this.is_attached = reader.ReadBool();
                    return true;
                case 0x8FEDBCFDu:
                    this.sticker = (InputFile)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x69330FC8u)]
    public partial class RemoveRecentSticker
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xFD0E148Cu:
                    this.is_attached = reader.ReadBool();
                    return true;
                case 0x8FEDBCFDu:
                    this.sticker = (InputFile)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDA16FDC5u)]
    public partial class ClearRecentStickers
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xFD0E148Cu:
                    this.is_attached = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1C542968u)]
    public partial class GetFavoriteStickers { }
    [TLTypeHash(0x58DF335Cu)]
    public partial class AddFavoriteSticker
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8FEDBCFDu:
                    this.sticker = (InputFile)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9EC8E281u)]
    public partial class RemoveFavoriteSticker
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8FEDBCFDu:
                    this.sticker = (InputFile)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x70F70E27u)]
    public partial class GetStickerEmojis
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8FEDBCFDu:
                    this.sticker = (InputFile)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x11089C5Cu)]
    public partial class GetSavedAnimations { }
    [TLTypeHash(0x4BC3C958u)]
    public partial class AddSavedAnimation
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8D5284DCu:
                    this.animation = (InputFile)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x50CBA662u)]
    public partial class RemoveSavedAnimation
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8D5284DCu:
                    this.animation = (InputFile)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x410E0FF2u)]
    public partial class GetRecentInlineBots { }
    [TLTypeHash(0x210E475Eu)]
    public partial class SearchHashtags
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x93B1868Eu:
                    this.prefix = reader.ReadStringAsUTF16String();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBC6B9954u)]
    public partial class RemoveRecentHashtag
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5AB52A61u:
                    this.hashtag = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xCD15F62Bu)]
    public partial class GetWebPagePreview
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3B8BA7C7u:
                    this.text = (FormattedText)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x218B182Eu)]
    public partial class GetWebPageInstantView
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF47645AEu:
                    this.url = reader.ReadStringAsUTF16String();
                    return true;
                case 0xCBC35FEEu:
                    this.force_full = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xEFBE0D60u)]
    public partial class SetProfilePhoto
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x14B78418u:
                    this.photo = (InputFile)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5E89D2A9u)]
    public partial class DeleteProfilePhoto
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x87F42D3Du:
                    this.profile_photo_id = reader.ReadIntegerString();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xCBD2C30Au)]
    public partial class SetName
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA9D1C132u:
                    this.first_name = reader.ReadStringAsUTF16String();
                    return true;
                case 0xC808BA5Au:
                    this.last_name = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x93D7E4B3u)]
    public partial class SetBio
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xDD206A7Bu:
                    this.bio = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF2CC63BBu)]
    public partial class SetUsername
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF85E0677u:
                    this.username = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD975D19Cu)]
    public partial class ChangePhoneNumber
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x6B01BC5Bu:
                    this.phone_number = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5C27A2A9u:
                    this.allow_flash_call = reader.ReadBool();
                    return true;
                case 0x546E8725u:
                    this.is_current_phone_number = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7457F172u)]
    public partial class ResendChangePhoneNumberCode { }
    [TLTypeHash(0x65C4B281u)]
    public partial class CheckChangePhoneNumberCode
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x77153098u:
                    this.code = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDD6D969Fu)]
    public partial class GetActiveSessions { }
    [TLTypeHash(0xEA2609B2u)]
    public partial class TerminateSession
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x613FECDFu:
                    this.session_id = reader.ReadIntegerString();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA57BCA19u)]
    public partial class TerminateAllOtherSessions { }
    [TLTypeHash(0x8AF649D3u)]
    public partial class GetConnectedWebsites { }
    [TLTypeHash(0x4F63437Bu)]
    public partial class DisconnectWebsite
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x18F45C82u:
                    this.website_id = reader.ReadIntegerString();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x716213B0u)]
    public partial class DisconnectAllWebsites { }
    [TLTypeHash(0x586AD986u)]
    public partial class ToggleBasicGroupAdministrators
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1B6DFDDBu:
                    this.basic_group_id = reader.ReadInt();
                    return true;
                case 0x96D4D2B3u:
                    this.everyone_is_administrator = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3087CAD5u)]
    public partial class SetSupergroupUsername
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x386CD096u:
                    this.supergroup_id = reader.ReadInt();
                    return true;
                case 0xF85E0677u:
                    this.username = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xFB6D6468u)]
    public partial class SetSupergroupStickerSet
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x386CD096u:
                    this.supergroup_id = reader.ReadInt();
                    return true;
                case 0xE417C78Fu:
                    this.sticker_set_id = reader.ReadIntegerString();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x538BB58Du)]
    public partial class ToggleSupergroupInvites
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x386CD096u:
                    this.supergroup_id = reader.ReadInt();
                    return true;
                case 0x36BEB4E3u:
                    this.anyone_can_invite = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8163708Fu)]
    public partial class ToggleSupergroupSignMessages
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x386CD096u:
                    this.supergroup_id = reader.ReadInt();
                    return true;
                case 0x18BBF871u:
                    this.sign_messages = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x752BEE27u)]
    public partial class ToggleSupergroupIsAllHistoryAvailable
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x386CD096u:
                    this.supergroup_id = reader.ReadInt();
                    return true;
                case 0xF4846EB9u:
                    this.is_all_history_available = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x2F583BD2u)]
    public partial class SetSupergroupDescription
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x386CD096u:
                    this.supergroup_id = reader.ReadInt();
                    return true;
                case 0x6DE44026u:
                    this.description = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xCB66D677u)]
    public partial class PinSupergroupMessage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x386CD096u:
                    this.supergroup_id = reader.ReadInt();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
                case 0x5771A509u:
                    this.disable_notification = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7CD39406u)]
    public partial class UnpinSupergroupMessage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x386CD096u:
                    this.supergroup_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x37EA024Du)]
    public partial class ReportSupergroupSpam
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x386CD096u:
                    this.supergroup_id = reader.ReadInt();
                    return true;
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0x59EF2D74u:
                    this.message_ids = reader.ReadArray<long>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE516B0B1u)]
    public partial class GetSupergroupMembers
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x386CD096u:
                    this.supergroup_id = reader.ReadInt();
                    return true;
                case 0x7FC45F1Du:
                    this.filter = (SupergroupMembersFilter)reader.ReadValue();
                    return true;
                case 0x590ACAD0u:
                    this.offset = reader.ReadInt();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB388D094u)]
    public partial class DeleteSupergroup
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x386CD096u:
                    this.supergroup_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA8A891F8u)]
    public partial class CloseSecretChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3C9AC102u:
                    this.secret_chat_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7ECFEF03u)]
    public partial class GetChatEventLog
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x24BDB5EBu:
                    this.query = reader.ReadStringAsUTF16String();
                    return true;
                case 0x37180811u:
                    this.from_event_id = reader.ReadIntegerString();
                    return true;
                case 0x7F96E860u:
                    this.limit = reader.ReadInt();
                    return true;
                case 0x7877678Du:
                    this.filters = (ChatEventLogFilters)reader.ReadValue();
                    return true;
                case 0x9BCCC613u:
                    this.user_ids = reader.ReadArray<int>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x69923B6Cu)]
    public partial class GetPaymentForm
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBDFD28AAu)]
    public partial class ValidateOrderInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
                case 0x86780B40u:
                    this.order_info = (OrderInfo)reader.ReadValue();
                    return true;
                case 0x45047CD1u:
                    this.allow_save = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7264676Bu)]
    public partial class SendPaymentForm
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
                case 0xABF168B3u:
                    this.order_info_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0xE1314C58u:
                    this.shipping_option_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0xFA05280Eu:
                    this.credentials = (InputCredentials)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0950C775u)]
    public partial class GetPaymentReceipt
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x537A1329u:
                    this.message_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xEE243CA1u)]
    public partial class GetSavedOrderInfo { }
    [TLTypeHash(0x86299066u)]
    public partial class DeleteSavedOrderInfo { }
    [TLTypeHash(0x93836C35u)]
    public partial class DeleteSavedCredentials { }
    [TLTypeHash(0x9A5758F6u)]
    public partial class GetSupportUser { }
    [TLTypeHash(0x072AFAC7u)]
    public partial class GetWallpapers { }
    [TLTypeHash(0x7840A569u)]
    public partial class GetLocalizationTargetInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x195F8866u:
                    this.only_local = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1CE2CBCAu)]
    public partial class GetLanguagePackStrings
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBDD46543u:
                    this.language_pack_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0xB48E44ECu:
                    this.keys = reader.ReadArray<string>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x66135D01u)]
    public partial class SetCustomLanguagePack
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xCB893157u:
                    this.info = (LanguagePackInfo)reader.ReadValue();
                    return true;
                case 0xB49A6AF5u:
                    this.strings = reader.ReadArray<LanguagePackString>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9FB4EF51u)]
    public partial class EditCustomLanguagePackInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xCB893157u:
                    this.info = (LanguagePackInfo)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9C3B20A3u)]
    public partial class SetCustomLanguagePackString
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBDD46543u:
                    this.language_pack_id = reader.ReadStringAsUTF16String();
                    return true;
                case 0x66248A83u:
                    this.new_string = (LanguagePackString)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xCB13C1F1u)]
    public partial class DeleteLanguagePack
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xBDD46543u:
                    this.language_pack_id = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x52B99BDCu)]
    public partial class RegisterDevice
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x99B2415Cu:
                    this.device_token = (DeviceToken)reader.ReadValue();
                    return true;
                case 0xDFDBB6FEu:
                    this.other_user_ids = reader.ReadArray<int>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x669220B4u)]
    public partial class GetRecentlyVisitedTMeUrls
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xED646567u:
                    this.referrer = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x0C1FE1DBu)]
    public partial class SetUserPrivacySettingRules
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x9F74B898u:
                    this.setting = (UserPrivacySetting)reader.ReadValue();
                    return true;
                case 0x899A993Cu:
                    this.rules = (UserPrivacySettingRules)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x8CD92C7Du)]
    public partial class GetUserPrivacySettingRules
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x9F74B898u:
                    this.setting = (UserPrivacySetting)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB2CF0601u)]
    public partial class GetOption
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5E237E06u:
                    this.name = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x43E3157Cu)]
    public partial class SetOption
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5E237E06u:
                    this.name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x1D775834u:
                    this.value = (OptionValue)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3C1E5372u)]
    public partial class SetAccountTtl
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA3EE881Fu:
                    this.ttl = (AccountTtl)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x48A09F3Eu)]
    public partial class GetAccountTtl { }
    [TLTypeHash(0x066CAAD9u)]
    public partial class DeleteAccount
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x3BB8880Cu:
                    this.reason = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4C3F4619u)]
    public partial class GetChatReportSpamState
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x6A628ED3u)]
    public partial class ChangeChatReportSpamState
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0xE3BE3938u:
                    this.is_spam_chat = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x783F3CE9u)]
    public partial class ReportChat
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
                case 0x3BB8880Cu:
                    this.reason = (ChatReportReason)reader.ReadValue();
                    return true;
                case 0x59EF2D74u:
                    this.message_ids = reader.ReadArray<long>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB9166C6Cu)]
    public partial class GetStorageStatistics
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x7EEB05FBu:
                    this.chat_limit = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1B4C22FAu)]
    public partial class GetStorageStatisticsFast { }
    [TLTypeHash(0xA9239890u)]
    public partial class OptimizeStorage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF7C0246Au:
                    this.size = reader.ReadLong();
                    return true;
                case 0xA3EE881Fu:
                    this.ttl = reader.ReadInt();
                    return true;
                case 0x85D94462u:
                    this.count = reader.ReadInt();
                    return true;
                case 0x6403E4D3u:
                    this.immunity_delay = reader.ReadInt();
                    return true;
                case 0xF3B33907u:
                    this.file_types = reader.ReadArray<FileType>();
                    return true;
                case 0x5010813Du:
                    this.chat_ids = reader.ReadArray<long>();
                    return true;
                case 0xF170C821u:
                    this.exclude_chat_ids = reader.ReadArray<long>();
                    return true;
                case 0x7EEB05FBu:
                    this.chat_limit = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x13513A83u)]
    public partial class SetNetworkType
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8CDE5729u:
                    this.type = (NetworkType)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xD6A8138Au)]
    public partial class GetNetworkStatistics
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x79F31347u:
                    this.only_current = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xABCA521Fu)]
    public partial class AddNetworkStatistics
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2B219D70u:
                    this.entry = (NetworkStatisticsEntry)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xF403A452u)]
    public partial class ResetNetworkStatistics { }
    [TLTypeHash(0x1D5341AAu)]
    public partial class GetPassportElement
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8CDE5729u:
                    this.type = (PassportElementType)reader.ReadValue();
                    return true;
                case 0x35C246D5u:
                    this.password = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA506CD13u)]
    public partial class GetAllPassportElements
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x35C246D5u:
                    this.password = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3858CAB4u)]
    public partial class SetPassportElement
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x41405E39u:
                    this.element = (InputPassportElement)reader.ReadValue();
                    return true;
                case 0x35C246D5u:
                    this.password = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x183B1B15u)]
    public partial class DeletePassportElement
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8CDE5729u:
                    this.type = (PassportElementType)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3DC26457u)]
    public partial class SetPassportElementErrors
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0x3C51531Du:
                    this.errors = reader.ReadArray<InputPassportElementError>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xB736CD49u)]
    public partial class GetPreferredCountryLanguage
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xF026BB7Cu:
                    this.country_code = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3C40A557u)]
    public partial class SendPhoneNumberVerificationCode
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x6B01BC5Bu:
                    this.phone_number = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5C27A2A9u:
                    this.allow_flash_call = reader.ReadBool();
                    return true;
                case 0x546E8725u:
                    this.is_current_phone_number = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xEDB56BA7u)]
    public partial class ResendPhoneNumberVerificationCode { }
    [TLTypeHash(0xD3F1A584u)]
    public partial class CheckPhoneNumberVerificationCode
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x77153098u:
                    this.code = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xABE1FB8Au)]
    public partial class SendEmailAddressVerificationCode
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xB08E074Eu:
                    this.email_address = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x168DFC58u)]
    public partial class ResendEmailAddressVerificationCode { }
    [TLTypeHash(0xB4D4C9E4u)]
    public partial class CheckEmailAddressVerificationCode
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x77153098u:
                    this.code = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xBEE171F7u)]
    public partial class GetPassportAuthorizationForm
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5898BEB0u:
                    this.bot_user_id = reader.ReadInt();
                    return true;
                case 0x00AF55D3u:
                    this.scope = reader.ReadStringAsUTF16String();
                    return true;
                case 0x66F9D463u:
                    this.public_key = reader.ReadStringAsUTF16String();
                    return true;
                case 0xB22492FDu:
                    this.nonce = reader.ReadStringAsUTF16String();
                    return true;
                case 0x35C246D5u:
                    this.password = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x6E7B5DC6u)]
    public partial class SendPassportAuthorizationForm
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x05E647A8u:
                    this.autorization_form_id = reader.ReadInt();
                    return true;
                case 0x59308930u:
                    this.types = reader.ReadArray<PassportElementType>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4D8CAFF0u)]
    public partial class SendPhoneNumberConfirmationCode
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xD1B862B8u:
                    this.hash = reader.ReadStringAsUTF16String();
                    return true;
                case 0x6B01BC5Bu:
                    this.phone_number = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5C27A2A9u:
                    this.allow_flash_call = reader.ReadBool();
                    return true;
                case 0x546E8725u:
                    this.is_current_phone_number = reader.ReadBool();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x9C796100u)]
    public partial class ResendPhoneNumberConfirmationCode { }
    [TLTypeHash(0xA23DAF23u)]
    public partial class CheckPhoneNumberConfirmationCode
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x77153098u:
                    this.code = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x92DB7F19u)]
    public partial class SetBotUpdatesStatus
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x79EF04C6u:
                    this.pending_update_count = reader.ReadInt();
                    return true;
                case 0x2BF96153u:
                    this.error_message = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4C099E24u)]
    public partial class UploadStickerFile
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0xFC0EB958u:
                    this.png_sticker = (InputFile)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x338885BAu)]
    public partial class CreateNewStickerSet
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0x2B36786Bu:
                    this.title = reader.ReadStringAsUTF16String();
                    return true;
                case 0x5E237E06u:
                    this.name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x71547314u:
                    this.is_masks = reader.ReadBool();
                    return true;
                case 0xD88DAC16u:
                    this.stickers = reader.ReadArray<InputSticker>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA7045155u)]
    public partial class AddStickerToSet
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA76ED395u:
                    this.user_id = reader.ReadInt();
                    return true;
                case 0x5E237E06u:
                    this.name = reader.ReadStringAsUTF16String();
                    return true;
                case 0x8FEDBCFDu:
                    this.sticker = (InputSticker)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x67470E8Eu)]
    public partial class SetStickerPositionInSet
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8FEDBCFDu:
                    this.sticker = (InputFile)reader.ReadValue();
                    return true;
                case 0x462CE4F5u:
                    this.position = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1DFD89DAu)]
    public partial class RemoveStickerFromSet
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8FEDBCFDu:
                    this.sticker = (InputFile)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x714DE988u)]
    public partial class GetMapThumbnailFile
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5E9E89CBu:
                    this.location = (Location)reader.ReadValue();
                    return true;
                case 0xB72B7974u:
                    this.zoom = reader.ReadInt();
                    return true;
                case 0x8C1A452Fu:
                    this.width = reader.ReadInt();
                    return true;
                case 0xF54DE50Fu:
                    this.height = reader.ReadInt();
                    return true;
                case 0xEC462584u:
                    this.scale = reader.ReadInt();
                    return true;
                case 0x1A9A7125u:
                    this.chat_id = reader.ReadLong();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x93FB20FBu)]
    public partial class AcceptTermsOfService
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0xA5DEBC29u:
                    this.terms_of_service_id = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x025BE18Cu)]
    public partial class SendCustomRequest
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5E593A60u:
                    this.method = reader.ReadStringAsUTF16String();
                    return true;
                case 0x069348FEu:
                    this.parameters = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3375D598u)]
    public partial class AnswerCustomQuery
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x0A4688FDu:
                    this.custom_query_id = reader.ReadIntegerString();
                    return true;
                case 0xADF3F363u:
                    this.data = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x7DBCFB4Bu)]
    public partial class SetAlarm
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x2FD609E6u:
                    this.seconds = reader.ReadDouble();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x4044011Eu)]
    public partial class GetCountryCode { }
    [TLTypeHash(0x7B7D279Fu)]
    public partial class GetInviteText { }
    [TLTypeHash(0x5FABB3CBu)]
    public partial class GetDeepLinkInfo
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x36AC99F1u:
                    this.link = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE16E4B51u)]
    public partial class AddProxy
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x5A6DD5F6u:
                    this.server = reader.ReadStringAsUTF16String();
                    return true;
                case 0x43915DCCu:
                    this.port = reader.ReadInt();
                    return true;
                case 0xF3A0C832u:
                    this.enable = reader.ReadBool();
                    return true;
                case 0x8CDE5729u:
                    this.type = (ProxyType)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x5E502942u)]
    public partial class EditProxy
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x0DB26A4Eu:
                    this.proxy_id = reader.ReadInt();
                    return true;
                case 0x5A6DD5F6u:
                    this.server = reader.ReadStringAsUTF16String();
                    return true;
                case 0x43915DCCu:
                    this.port = reader.ReadInt();
                    return true;
                case 0xF3A0C832u:
                    this.enable = reader.ReadBool();
                    return true;
                case 0x8CDE5729u:
                    this.type = (ProxyType)reader.ReadValue();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x3C4224ABu)]
    public partial class EnableProxy
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x0DB26A4Eu:
                    this.proxy_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xDF0E9CC0u)]
    public partial class DisableProxy { }
    [TLTypeHash(0xFDF02B51u)]
    public partial class RemoveProxy
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x0DB26A4Eu:
                    this.proxy_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA8094EA7u)]
    public partial class GetProxies { }
    [TLTypeHash(0xBC8E5326u)]
    public partial class GetProxyLink
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x0DB26A4Eu:
                    this.proxy_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x63E77516u)]
    public partial class PingProxy
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x0DB26A4Eu:
                    this.proxy_id = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xFAF0C912u)]
    public partial class TestCallEmpty { }
    [TLTypeHash(0xF19CF2BCu)]
    public partial class TestCallString
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8CDC1683u:
                    this.x = reader.ReadStringAsUTF16String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x23AEB718u)]
    public partial class TestCallBytes
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8CDC1683u:
                    this.x = reader.ReadBase64String();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xE1ABBB5Cu)]
    public partial class TestCallVectorInt
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8CDC1683u:
                    this.x = reader.ReadArray<int>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x81107BC0u)]
    public partial class TestCallVectorIntObject
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8CDC1683u:
                    this.x = reader.ReadArray<TestInt>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x1E0AB04Bu)]
    public partial class TestCallVectorString
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8CDC1683u:
                    this.x = reader.ReadArray<string>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xA35C327Fu)]
    public partial class TestCallVectorStringObject
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8CDC1683u:
                    this.x = reader.ReadArray<TestString>();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0x57C0648Bu)]
    public partial class TestSquareInt
    {
        internal override bool TdJsonReadItem(ref TdJsonReader reader, uint hash)
        {
            if (base.TdJsonReadItem(ref reader, hash)) return true;
            switch (hash)
            {
                case 0x8CDC1683u:
                    this.x = reader.ReadInt();
                    return true;
            }
            return false;
        }
    }

    [TLTypeHash(0xC1D35E8Du)]
    public partial class TestNetwork { }
    [TLTypeHash(0x38BC48A9u)]
    public partial class TestGetDifference { }
    [TLTypeHash(0xB0753A7Du)]
    public partial class TestUseUpdate { }
    [TLTypeHash(0x0F6A2749u)]
    public partial class TestUseError { }
}
