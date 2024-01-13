unit untEmloyee;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants,
  System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Data.DB, Vcl.StdCtrls, Vcl.Grids,
  Vcl.DBGrids,
  FireDAC.Stan.Intf, FireDAC.Stan.Option, FireDAC.Stan.Param,
  FireDAC.Stan.Error,
  FireDAC.DatS, FireDAC.Phys.Intf, FireDAC.DApt.Intf, FireDAC.Stan.Async,
  FireDAC.DApt,
  FireDAC.Comp.DataSet, FireDAC.Comp.Client;

type
  TfrmEmployee = class(TForm)
    dsEmployee: TDataSource;
    dbgEmployee: TDBGrid;
    Button1: TButton;
    Button2: TButton;
    tblEmployee: TFDTable;
    qrEmployee: TFDQuery;
    procedure dsEmployeeDataChange(Sender: TObject; Field: TField);
    procedure Button2Click(Sender: TObject);
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
    procedure EmployeeDelete(Index: LongInt);
  public
    { Public declarations }
  end;

var
  frmEmployee: TfrmEmployee;
  Idx: LongInt; // ������ ������ ���������� ��� ����������� �� ������� �������

implementation

{$R *.dfm}

uses untSettings, untEmployeeAdd;

// ����� ������ �� �������� � ��� ������������� �������� ��������� ��������
procedure TfrmEmployee.Button1Click(Sender: TObject);
begin
  frmEmployeeAdd.ShowModal;
end;

procedure TfrmEmployee.Button2Click(Sender: TObject);
var
  Ans: Byte;
begin
  Ans := MessageBox(Handle, '������� ����������?', '���������',
    MB_ICONQUESTION + MB_YESNO);
  if Ans = mrYes then
  begin
    EmployeeDelete(Idx);
    dbgEmployee.DataSource.DataSet.Refresh;
  end;
end;

procedure TfrmEmployee.dsEmployeeDataChange(Sender: TObject; Field: TField);
begin
  Idx := dbgEmployee.DataSource.DataSet.FieldByName('idemployee').AsInteger;
end;

// ��������� �������� ����������
procedure TfrmEmployee.EmployeeDelete(Index: LongInt);
begin
  with qrEmployee do
  begin
    Close;
    SQL.Clear;
    SQL.Add('DELETE FROM Employee WHERE idemployee = :idx');
    Params[0].Value := Idx;
    try
      ExecSQL;
      MessageBox(Handle, '��������� �����', '���������', MB_ICONINFORMATION);
    except
      MessageBox(Handle, '������ �������� ����������', '������', MB_ICONERROR);
    end;
  end;
end;

end.
