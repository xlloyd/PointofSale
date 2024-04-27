SELECT * FROM tblMain m 
                 INNER JOIN tblDetails d ON m.MainID = d.MainID 
                 INNER JOIN products p ON p.pID = d.proID 
                 
