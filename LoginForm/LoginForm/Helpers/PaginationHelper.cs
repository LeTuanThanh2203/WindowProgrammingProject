using System;
using System.Data;
using System.Windows.Forms;

namespace LoginForm
{
    public class PaginationHelper
    {
        private DataTable _fullData;
        private int _pageSize = 10;
        private int _currentPage = 1;
        private readonly Action<DataTable> _onPageChanged;
        private readonly Label _lblPageInfo;
        private readonly Label _lblTotal;
        private readonly Button _btnFirst;
        private readonly Button _btnPrev;
        private readonly Button _btnNext;
        private readonly Button _btnLast;
        private readonly ComboBox _cboPageSize;

        public int CurrentPage => _currentPage;
        public int PageSize => _pageSize;
        public int TotalPages => _fullData == null ? 0 : (int)Math.Ceiling((double)_fullData.Rows.Count / _pageSize);

        public PaginationHelper(
            Action<DataTable> onPageChanged,
            Label lblPageInfo,
            Label lblTotal,
            Button btnFirst,
            Button btnPrev,
            Button btnNext,
            Button btnLast,
            ComboBox cboPageSize)
        {
            _onPageChanged = onPageChanged;
            _lblPageInfo = lblPageInfo;
            _lblTotal = lblTotal;
            _btnFirst = btnFirst;
            _btnPrev = btnPrev;
            _btnNext = btnNext;
            _btnLast = btnLast;
            _cboPageSize = cboPageSize;

            _btnFirst.Click += (s, e) => GoToPage(1);
            _btnPrev.Click += (s, e) => GoToPage(_currentPage - 1);
            _btnNext.Click += (s, e) => GoToPage(_currentPage + 1);
            _btnLast.Click += (s, e) => GoToPage(TotalPages);

            if (_cboPageSize != null)
            {
                _cboPageSize.Items.Clear();
                _cboPageSize.Items.AddRange(new object[] { "10", "20", "50" });
                _cboPageSize.SelectedIndex = 0;
                _cboPageSize.SelectedIndexChanged += (s, e) =>
                {
                    if (int.TryParse(_cboPageSize.SelectedItem?.ToString(), out int val))
                    {
                        _pageSize = val;
                        _currentPage = 1;
                        UpdatePage();
                    }
                };
            }
        }

        public void SetData(DataTable data)
        {
            _fullData = data;
            int total = TotalPages;
            if (_currentPage > total) _currentPage = total;
            if (_currentPage < 1) _currentPage = 1;
            UpdatePage();
        }

        public void ResetPage() => _currentPage = 1;

        public void GoToPage(int page)
        {
            int total = TotalPages;
            if (page > total) page = total;
            if (page < 1) page = 1;

            if (_currentPage != page)
            {
                _currentPage = page;
                UpdatePage();
            }
        }

        public void UpdatePage()
        {
            if (_fullData == null || _fullData.Rows.Count == 0)
            {
                _onPageChanged?.Invoke(new DataTable());
                if (_lblPageInfo != null) _lblPageInfo.Text = "Page 0 of 0";
                if (_lblTotal != null) _lblTotal.Text = "Total Records: 0";
                _btnFirst.Enabled = _btnPrev.Enabled = _btnNext.Enabled = _btnLast.Enabled = false;
                return;
            }

            int totalRows = _fullData.Rows.Count;
            int totalPages = TotalPages;

            if (_currentPage > totalPages) _currentPage = totalPages;
            if (_currentPage < 1) _currentPage = 1;

            DataTable pageTable = _fullData.Clone();
            int startIndex = (_currentPage - 1) * _pageSize;
            int endIndex = Math.Min(startIndex + _pageSize, totalRows);
            for (int i = startIndex; i < endIndex; i++)
            {
                pageTable.ImportRow(_fullData.Rows[i]);
            }

            _onPageChanged?.Invoke(pageTable);

            if (_lblPageInfo != null) _lblPageInfo.Text = $"Page {_currentPage} of {totalPages}";
            if (_lblTotal != null) _lblTotal.Text = $"Total Records: {totalRows}";
            _btnFirst.Enabled = _currentPage > 1;
            _btnPrev.Enabled = _currentPage > 1;
            _btnNext.Enabled = _currentPage < totalPages;
            _btnLast.Enabled = _currentPage < totalPages;
        }
    }
}
