-- SQLite

INSERT INTO
    Empresas (Descripcion, Codigo, Estado)
VALUES ('ABONAP', 'EMPABO00001', 1);

INSERT INTO
    Sucursales (
        Codigo,
        Descripcion,
        EmpresaId,
        Estado
    )
VALUES (
        'SUC00001',
        'AVENIDA LIBERTAD',
        1,
        1
    );

INSERT INTO
    Sucursales (
        Codigo,
        Descripcion,
        EmpresaId,
        Estado
    )
VALUES (
        'SUC00002',
        '16 DE AGOSTO',
        1,
        1
    );

INSERT INTO
    Sucursales (
        Codigo,
        Descripcion,
        EmpresaId,
        Estado
    )
VALUES ('SUC00008', 'SANTIAGO', 1, 1);

INSERT INTO
    Sucursales (
        Codigo,
        Descripcion,
        EmpresaId,
        Estado
    )
VALUES (
        'SUC00009',
        'SANTO DOMINGO',
        1,
        1
    );

INSERT INTO
    Departamentos (
        Descripcion,
        SucursalId,
        Codigo,
        Estado
    )
VALUES (
        'TECNOLOGIA',
        1,
        'DEPTEC00001',
        1
    );

INSERT INTO
    Departamentos (
        Descripcion,
        SucursalId,
        Codigo,
        Estado
    )
VALUES (
        'OPERACIONES',
        1,
        'DEPOPE00003',
        1
    );

INSERT INTO
    Departamentos (
        Descripcion,
        SucursalId,
        Codigo,
        Estado
    )
VALUES ('NEGOCIOS', 1, 'DEPNEG00002', 1);

INSERT INTO
    Personas (
        Nombre,
        PrimerApellido,
        SegundoApellido,
        Codigo,
        Estado
    )
VALUES (
        'RONALD',
        'PAULINO',
        'ALBERTO',
        'PER1508539',
        1
    );

INSERT INTO
    Personas (
        Nombre,
        PrimerApellido,
        SegundoApellido,
        Codigo,
        Estado
    )
VALUES (
        'ALEXANDER',
        'ALMONTE',
        'TINEO',
        'PER2098250',
        1
    );

INSERT INTO
    Personas (
        Nombre,
        PrimerApellido,
        SegundoApellido,
        Codigo,
        Estado
    )
VALUES (
        'WILLY CARLOS',
        'PORTALATIN',
        'OWEN',
        'PER5845931',
        1
    );

INSERT INTO
    TipoDocumentos (Descripcion, Codigo, Estado)
VALUES ('RNC', '1', 1);

INSERT INTO
    TipoDocumentos (Descripcion, Codigo, Estado)
VALUES ('CEDULA', '2', 1);

INSERT INTO
    TipoDocumentos (Descripcion, Codigo, Estado)
VALUES ('PASAPORTE', '3', 1);

INSERT INTO
    Documentos (
        Descripcion,
        Estado,
        TipoDocumentoId
    )
VALUES ('402-7896247-3', 1, 2);

INSERT INTO
    Documentos (
        Descripcion,
        Estado,
        TipoDocumentoId
    )
VALUES ('048-0089654-4 ', 1, 2);

INSERT INTO
    Documentos (
        Descripcion,
        Estado,
        TipoDocumentoId
    )
VALUES ('047-98745960 ', 1, 2);

INSERT INTO
    Documentos (
        Descripcion,
        Estado,
        TipoDocumentoId
    )
VALUES ('005-87598-9', 0, 1);