import React, { useState } from 'react';
import { useTable, useSortBy, useGlobalFilter } from 'react-table';

const Table = ({ data }:any) => {
  const [searchQuery, setSearchQuery] = useState('');

  const columns = React.useMemo(
    () => [
      { Header: 'Date', accessor: 'date' },
      { Header: 'Name', accessor: 'name' },
      { Header: 'Email', accessor: 'email' },
      { Header: 'Phonenumber', accessor: 'phonenumber' },
      { Header: 'Location', accessor: 'location' },
      { Header: 'Time', accessor: 'time' },
    ],
    []
  );

  const {
    getTableProps,
    getTableBodyProps,
    headerGroups,
    rows,
    prepareRow,
  } = useTable(
    {
      columns,
      data,
    },
    useGlobalFilter,
    useSortBy
  );

  const handleSearchChange = (e:any) => {
    setSearchQuery(e.target.value);
  };


  return (
    <>
          <table className=" bg-white border border-gray-300">
        <thead>
          {headerGroups.map((headerGroup) => (
            <tr {...headerGroup.getHeaderGroupProps()} className="bg-gray-100">
              {headerGroup.headers.map((column) => (
                <th
                  {...column.getHeaderProps()}
                  className="px-5 py-2 text-left font-semibold text-gray-700"
                >
                  {column.render('Header')}
                </th>
              ))}
            </tr>
          ))}
        </thead>
        <tbody {...getTableBodyProps()}>
          {rows.map((row) => {
            prepareRow(row);
            return (
              <tr {...row.getRowProps()} className="border-b border-gray-300">
                {row.cells.map((cell) => {
                  return (
                    <td
                      {...cell.getCellProps()}
                      className="px-6 py-4 whitespace-nowrap"
                    >
                      {cell.render('Cell')}
                    </td>
                  );
                })}
              </tr>
            );
          })}
        </tbody>
      </table>
    </>
  );
};

export default Table;
