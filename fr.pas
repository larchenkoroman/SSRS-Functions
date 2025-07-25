procedure BorderAddBottom(aMemo: TfrxMemoView);
begin
  aMemo.Frame.Typ := aMemo.Frame.Typ + ftBottom;
end;

procedure AddBoldItalic(aMemo: TfrxMemoView);
begin
  aMemo.Font.Style := aMemo.Font.Style + fsBold + fsItalic;
end;

function MonthRusName(dt: TDateTime): string;
begin
  case MonthOf(dt) of
    1: Result := 'января';
    2: Result := 'февраля';
    3: Result := 'марта';
    4: Result := 'апреля';
    5: Result := 'мая';
    6: Result := 'июня';
    7: Result := 'июля';
    8: Result := 'августа';
    9: Result := 'сентября';
    10: Result := 'октября';
    11: Result := 'ноября';
    12: Result := 'декабря';
    else
      Result := '';
  end
end;

function YearFirstTwoDigits(dt: TDateTime): string;
begin
  Result := Copy(FormatDateTime('yyyy', dt), 1, 2);
end;

function YearLastTwoDigits(dt: TDateTime): string;
begin
  Result := Copy(FormatDateTime('yyyy', dt), 3, 2);
end;
-------------------------------------------------------------


var
  MaxDatesRn: Integer;

function MonthRusName(dt: TDateTime): string;
begin
  case MonthOf(dt) of
    1: Result := 'января';
    2: Result := 'февраля';
    3: Result := 'марта';
    4: Result := 'апреля';
    5: Result := 'мая';
    6: Result := 'июня';
    7: Result := 'июля';
    8: Result := 'августа';
    9: Result := 'сентября';
    10: Result := 'октября';
    11: Result := 'ноября';
    12: Result := 'декабря';
    else
      Result := '';
  end
end;

procedure CreateDateMemo(ColIndex:Integer; ColText: string; ParentHeader: TfrxBand);
var
  StartLeft, StartTop, ColWidth: Extended;
  memoDate: TfrxMemoView;
begin
  ColWidth := Memo44.Width;//45;
  StartLeft := Memo21.Left + (ColIndex - 1) * ColWidth;
  StartTop := Memo21.Top + Memo21.Height;
  memoDate := TfrxMemoView.Create(ParentHeader);
  memoDate.Name := ParentHeader.Name + '_MemoDate' + IntToStr(ColIndex);
  memoDate.SetBounds(StartLeft, StartTop, ColWidth , Memo20.Height - Memo21.Height);
  memoDate.Text := ColText;
  memoDate.Frame := Memo21.Frame;
  memoDate.Rotation := 90;
  memoDate.HAlign := haCenter;
  memoDate.VAlign := vaCenter;
end;

procedure CreateDateMemos(Lo, Hi: Integer; ParentHeader: TfrxBand; Page: TfrxReportPage);
var
  i: Integer;
  str: string;
begin
  if MaxDatesRn < Lo then
  begin
    Page.Visible := False;
    exit;
  end;

  qDates.Filter := '(rn >= ' + IntToStr(Lo) + ') and (rn <= ' + IntToStr(Hi) + ')';
  qDates.Filtered := True;

  if qDates.Eof then
  begin
    qDates.Filtered := False;
    Page.Visible := False;
    exit;
  end;

  qDates.First;
  for i := 1 to 15 do
  begin
    if not qDates.Eof then
    begin
      str:= qDates.FieldByName('DateRu').AsString;
      qDates.Next;
    end
    else
    begin
      str := '';
    end;
    CreateDateMemo(i, str, ParentHeader);
  end;
  qDates.Filtered := False;
end;


procedure Memo317OnAfterData(Sender: TfrxComponent);
begin
  if Memo317.Text = '' then
  begin
    Memo317.Visible := false;
    ReportTitle1.Height := ReportTitle1.Height - Memo317.Height;
  end;
end;

procedure Memo318OnAfterData(Sender: TfrxComponent);
begin
  if Memo318.Text = '' then
  begin
    Memo318.Visible := false;
    ReportTitle1.Height := ReportTitle1.Height - Memo318.Height;
  end;
end;

begin
  if not qDates.Active then
    qDates.Open;

  qDates.Last;
  MaxDatesRn := qDates.FieldByName('rn').AsInteger;
  qDates.First;

  CreateDateMemos(1, 15, Header1, Page1);
  CreateDateMemos(16, 30, Header2, Page2);
  CreateDateMemos(31, 45, Header3, Page3);
  CreateDateMemos(46, 60, Header4, Page4);
  CreateDateMemos(61, 75, Header5, Page5);
  CreateDateMemos(76, 90, Header6, Page6);
  CreateDateMemos(91, 105, Header7, Page7);
  CreateDateMemos(106, 120, Header8, Page8);
  CreateDateMemos(121, 135, Header9, Page9);
  CreateDateMemos(136, 150, Header10, Page10);
  CreateDateMemos(151, 165, Header11, Page11);
  CreateDateMemos(166, 180, Header12, Page12);
end.