<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/BackAdmin.Master" ValidateRequest="false" AutoEventWireup="true" CodeBehind="ProdAddEdit.aspx.cs" Inherits="Ecommerce.AdminManage.ProdAdddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">ניהול מוצרים</h1>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    עריכה/הוספה מוצר
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-lg-6">
                            <asp:HiddenField ID="HidPid" runat="server" value="-1"/>
                            <div class="form-group">
                                <label>שם המוצר</label>
                                <asp:TextBox ID="TxtPname" CssClass="form-control" runat="server" placeholder="נא הזן שם מוצר" />
                            </div>
                            <div class="form-group">
                                <label>מחיר</label>
                                <asp:TextBox ID="TxtPrice" CssClass="form-control" runat="server" placeholder="נא הזן מחיר" />
                            </div>
                            <div class="form-group">
                                <label>תיאור מוצר</label>
                                <asp:TextBox ID="TxtPdesc" CssClass="form-control" runat="server" TextMode="MultiLine" Rows="10" Columns="40" placeholder="נא הזן שם תיאור" />
                            </div>

                            <div class="form-group">
                                <asp:Image ID="ImgPicname" CssClass="form-control" runat="server"  />
                            </div>

                            <div class="form-group">
                                <label>תמונת מוצר</label>
                                <asp:FileUpload ID="UploadPic" runat="server" />
                            </div>
                           

                            <asp:Button ID="BtnSave" runat="server" class="btn btn-primary" OnClick="BtnSave_Click" Text="שמירה"/>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="UnderfooterCnt" runat="server">
    <script src="https://cdn.ckeditor.com/ckeditor5/41.4.2/classic/ckeditor.js"></script>
 <script src="https://cdn.ckeditor.com/ckeditor5/34.1.0/classic/ckeditor.js"></script>
<script>
    ClassicEditor
        .create(document.querySelector('#MainCnt_TxtPdesc'), {
            toolbar: {
                items: [
                    'heading',
                    '|',
                    'bold',
                    'italic',
                    'underline',
                    'strikethrough',
                    'subscript',
                    'superscript',
                    'fontColor',
                    'fontBackgroundColor',
                    'link',
                    '|',
                    'bulletedList',
                    'numberedList',
                    '|',
                    'alignment',
                    'indent',
                    'outdent',
                    '|',
                    'blockQuote',
                    'insertTable',
                    'insertImage',
                    'mediaEmbed',
                    '|',
                    'undo',
                    'redo'
                ]
            },
            language: 'he',
            image: {
                toolbar: [
                    'imageTextAlternative',
                    'imageStyle:inline',
                    'imageStyle:block',
                    'imageStyle:side',
                    'linkImage'
                ]
            },
            table: {
                contentToolbar: [
                    'tableColumn',
                    'tableRow',
                    'mergeTableCells',
                    'tableCellProperties',
                    'tableProperties'
                ]
            },
            link: {
                decorators: {
                    addTargetToExternalLinks: true,
                    defaultProtocol: 'https://'
                }
            },
            mediaEmbed: {
                previewsInData: true
            },
            fontColor: {
                colors: [
                    {
                        color: 'hsl(0, 0%, 0%)',
                        label: 'Black'
                    },
                    {
                        color: 'hsl(0, 75%, 60%)',
                        label: 'Red'
                    },
                    {
                        color: 'hsl(30, 75%, 60%)',
                        label: 'Orange'
                    },
                    {
                        color: 'hsl(60, 75%, 60%)',
                        label: 'Yellow'
                    },
                    {
                        color: 'hsl(90, 75%, 60%)',
                        label: 'Light Green'
                    },
                    {
                        color: 'hsl(120, 75%, 60%)',
                        label: 'Green'
                    },
                    {
                        color: 'hsl(150, 75%, 60%)',
                        label: 'Aquamarine'
                    },
                    {
                        color: 'hsl(180, 75%, 60%)',
                        label: 'Turquoise'
                    },
                    {
                        color: 'hsl(210, 75%, 60%)',
                        label: 'Light Blue'
                    },
                    {
                        color: 'hsl(240, 75%, 60%)',
                        label: 'Blue'
                    },
                    {
                        color: 'hsl(270, 75%, 60%)',
                        label: 'Purple'
                    }
                ]
            },
            fontBackgroundColor: {
                colors: [
                    {
                        color: 'hsl(0, 0%, 0%)',
                        label: 'Black'
                    },
                    {
                        color: 'hsl(0, 75%, 60%)',
                        label: 'Red'
                    },
                    {
                        color: 'hsl(30, 75%, 60%)',
                        label: 'Orange'
                    },
                    {
                        color: 'hsl(60, 75%, 60%)',
                        label: 'Yellow'
                    },
                    {
                        color: 'hsl(90, 75%, 60%)',
                        label: 'Light Green'
                    },
                    {
                        color: 'hsl(120, 75%, 60%)',
                        label: 'Green'
                    },
                    {
                        color: 'hsl(150, 75%, 60%)',
                        label: 'Aquamarine'
                    },
                    {
                        color: 'hsl(180, 75%, 60%)',
                        label: 'Turquoise'
                    },
                    {
                        color: 'hsl(210, 75%, 60%)',
                        label: 'Light Blue'
                    },
                    {
                        color: 'hsl(240, 75%, 60%)',
                        label: 'Blue'
                    },
                    {
                        color: 'hsl(270, 75%, 60%)',
                        label: 'Purple'
                    }
                ]
            }
        })
        .then(editor => {
            console.log('Editor was initialized', editor);
        })
        .catch(error => {
            console.error('Error initializing editor:', error);
        });
</script>





</asp:Content>
