namespace AdventOfCode2024.Inputs;

public static partial class Input
{
    public const string Day04 =
@"MSAMXXMASXSXMMSASXMASMXMASXSXSSMSSSMMMSSSSMSAMXASAMXXAXMSMMMAXMAMSAMXAMXMXXMXMASMXSAXMXMAMXSXSXXMSSXMSSMMSSMMMMXSXAXMXMAMMASMSXSXSSXMSSMSSMM
MSASASAAXSMAMMSAMXSXXMAMXSASAAAASMSASAASAAAMMMSXXMMMSMMXAAASMMMMSAMXSAXASMMSSMMXAXXMSSXXMSMMASMXMASXAAXAAAAAAMAASXSAMAXSMSMMASAXAXAAAAAMAAAS
ASAMASMMMASXMAMAMXXAXSMSAMAMMMMMMAMMMMXXMMMMSASXXMAXAASXSSMSASAMXMSAMXSASAMAASAMXMAAAMXMASAMAMXMMASMMMSMMSSMMMMMSAAASMSMAAMSAMAMXMXMMXSMXXMM
MMAMAMAAAMAMMASMMXMMMXAAMMXMMXXXMXSXASXSMSXXMASAMSSSMSMAAMASXMASAAMASXSAMXMSSMMXSMMMXSAXAXAMSSMAMASXMASXMAMMSMMASAMXMMAMMMMMXSXMSMXMASMXSASA
XSAMAXSMSXAMSASASXMAAXSSMXXXAXMXSAAXXSAAASASMAMAXAXAMXMSMMMMMSAMMMSXMMMAMXAXAAAAMXMSAXMSSMSMASASMAMXMASXMAXAAAMMSAXXSSXMXSXMXXAMXMMMSMAASMMS
MSXMMXMXXMMMMASAMMSMXXAAXXSASMMAMAMMXMMMMMAMMASAMMSAMSXMASXXXSAXSXSMSAMASXMSSMMSXAXMASMXMAXMMXSAMSSSMXSASAMXSSMXSASAMXMAXMASMSSMASAXAMMMSMAM
XMAMSAMMSAMXMMMMMAASMMSAMXXMMAMASMXSAMASXMXMXASASXAAASASAMMMASXMSXMASXSASAMAMXAMMSMMXMXAMAMAMSMMSAMAAMSAMXSAAXMASAMXMXMASMXMASASASXSMAXAXMAS
SMAMXASAMAMXMMXAMSSSXAMASXXXXXSASAAXASASXMAXMXXXMMXMXSAMXSXAXSMMMAMAMAMMSXMMSMASAAAMXSSMMXSXMAAXMASMMMMAMAMMMMMXSXXAAASAMXAXXSAMXSAMXSMMXSAS
XSXSSMMXSAMXMMMMMMAMMXSAMMMMSXMAMMMSAMASASMSSSXAXMAMXMMMMMXSAMAAXAMASXSAMXXSAMXMMSMMAXASAAMASXSMSMMMAAXAMSMSAMSASXSMSMSAMSMMMMMMSMMMAMASXMAS
MAMXAAAAXMMAMAAMAMSMSXMASAAAAAMXMAASXMMMMMAAAXSXASAXMXMAXSAMXSSMSSSXSXMXSAXXMSAMXXXMXSAMMMSAMAAAAMASXMXMMMAMAMSAMAXAMASMMAMASAMXAAAMAMAMAMAM
SAAMSMMSSXXAXSMSAXXASXMXSXMMSAMXMMMSXSXSAMMMSMMSMMAXSASASMAMAXAAAAAAMMSXMXSXASMSAMAMAMAMXAMAXXXMAMASAMASAMAMMAMAMSMMMAMASXSASASAMSMSMSSSSMAM
SXMAAXXAAMSXXAASMMMMMAXMSAMXXAMXXMXMXXAXAXXMAAMXXMSMSASXXMSMMSAMMSMAMAMAMAMMXMXMAXAMASAMMMXSMXMASMMSASASASXSMMMMAAAXMASMSAMXXAMMXAXAMXMAMSAS
SAASAXSMXMAMMMMMMAXASXMASMMMSAMMSMAMSMSMSMAMSXXASMMAMMMMSMMAMSXXAXXXMMSAMASASXSXMMXMAMASAMAAMMMAAAASXMASMMXXXXAASXXMXAAXMMMSMMSAMXSMSSMAMSXS
SAMAAMSXSMMSMAAXMMSMMMAMSXAAXSMSASASXAAAMSSMMMSXSAMXMAMASASAMXMMMSAMXAMASXXASMSAMSSMSSXMAMSSSXMXSMMSXXXSAMXAXMMMMASXSMMXXSAMXAAAMAAXAXMAXXAM
MAXXSXSAMMXAXMSSMMMXMMSMMMSSXXXSAXXXMXMXMAXXAXMASMMSSSMASMMAMAAMAXAMMSSMMXMMMAMAMAAAAXAMMMXAMMMMXXAMXMMSAMMMMAMSMAMAAAMMMMAMMXSMMMXMASMMSMAM
XMMMXMMAMSSMSXAXMAASMAXAXAAXMMMMSMASXXSAMAMSMSMAMXSXAAMAMMXMSSMSMSAMAAXAAXMASMSAMSMMMXMMAXMAMAAMMMXXAAAXXMAMMAXXMASMMMMAMMAMSMMAAXSAMXXAAMXM
AMAXAMSMMMAASMMSXMXMMAMMMSXMAAAAMMMMAASASAAAAAMXXXMMMMMSMSAMXMAAXSAMMSSMMSSMMAXXMAMASAXMMMSAXMSSMAAXSXMSASXSMMXSAMXMXSXSMMAMXASXMSXXMAMXXSXM
XXAMXMAAASMMMAMAMSMSMSSXAXMASXMSMMXMXMXASASMSMSSXSMSXSAXXXASAMXMMMAMAMXAXAMXMASXSMSASXSAAXSMSMXAMMSXMAXXMAMAAAMAMXASXSAXAMMSMXMAXXMSMSSSSMAX
MXSXMMSSMSAMXSMMMAASAXMMXSAMAAMAXSAMXXMAMAXAXAAXAXAAAMXSMSMMASAMXSXMASXSMSMXMMSAAAMASASMMMMAAXMXMMMAMXMASMSSMSSSMSXSAMAMMXMAMXXMMSMSAAAMXSMM
SAMAAAAAXSXMAXAXSMSMXMASMSXSXXMAXSASMSXMMSMAMMMMMMMMSMMXMAMXAMASAAXSSSMMAMAAMXMMMMMAMXMAAASXMMXMMXMXMSMXAAAAAXAMXXAMAMAMXXSASMMXAMAMAMSAAAMA
MASXMMXSMMMMMSXMASXMMAAXASAMXSXSASAMMXXAAAASXMMXMXMAXAAASASMASXMXSXXAXAMAMSSSSSXMAMAMAXSMXXAASMASAXMXAXAXXMXSMSMXMSMASXSAXMASAAASMXMXXXMSSMS
MAMMXSAMASXAMXASMMMASMSMMMXMMMAMMMAMAMSMSSXXAXSAMMSMMSSMSASXXSMSAMMMMMSSXXAMMAXMMMXAXXXXMMSMMAASMXXAXMSMSXSAMMXSXXXSMSAMMSMAMMMSMAMXXMSXMAXA
MMSMAMXMXMMMMMAMAXMAXMAMXSXSAMMMXSAMAMXAMXASAMSASAMXAXAMXXMASMAMMMMAXXXMMMASMSMMXMASMSXSAAXASMSMSMMXAXAXMXMASXAAMXMMMMXMSXMXMMXXXXSXASMASMMM
MSAMMSMSSSXSAAAXXMMAMSAMASASAMMSXMXSAMMAMMMMMXSAMXAMXSAMXMXXXMSMXXMMSMSMXSSMAXAXAMAMAXAXMMSXMXAMAMASASMXSAXMMMMSMASAMXAXXAMASMMSMMSXMXSXMXAX
MXASAAAXAAASXXMXSAMXAMASXMMMXSSMMSASAXSSMSXASMMXMMXMMSAMMXSMMMXMAXSAAAAAAMAMMMMSASXMSMSMMAXXXMXSAXMAMXMASMMMXAMAXXSXSXMASAMASAAAAAMAMMMMMSSM
SSMMXXSMMMMMAMSASXSMMSASXMAMMMXAASMMSMAAXASAXASXSMSXASASAMXAMSAXAMMSMSMSXXAAMXXMAXAAMMMAMXSSSSMSMXMAMAMMMXAXSXSASMSAMXXAMAXASMMMSMXAMAAAXAAS
XAMXMMMAXXXMXMMASAXAAMXMASMSASMMMSXAXMSMMMAXSAMXSAXMXSAMMMSXMXMXASAXXAAAXSSSMXXXMMMMMASAMXAAMSASASXSSSSMSMMXAAMASXSAXAMMSSMMSMSXMMSSSSSSMMSM
SAMXSASXSXSMMXMAMAMMMSASXMASMSAAAMMSSMXAMXAAMAMAMXMMMXXMAMXSAAMSXMASXMSMMMMAMXMMMASXSMSASXMXMMXMAMAAXAAAAASMXMMXMASXMMSMAMAXMAMAXMAMXMAMXXAM
MMSMMMSASAMXAXMASXSXSAMXAMMMXSXMMXAXAAXMAXMXMAMASAMMASASXXAAXMMASMAMAXXXAASAMASASASAXXXXMAXSMSMMMMMMMSMMMAMAAXMSAMXMXAAMMSSMMAXMMMASMMSMSMMS
MAAXAXMAMXMASXMXMMXMAXXSAMXSMSMMMMXXMMMSSSMXXASAXXXAMXAXAMSSMSXASMXSXMXASMXASMSASAMXMMSMSXMMAAXAXXXMAXXXMASMMSAMMMAXMASMMMASXAASASASMAMASAMX
MSSMMSXXAAMXXXMAAMMSSXMMXXMSAXMAASMSMXXAAAASMMMMSMSSSMXMMMMAAXMASXMAMXMMMXMAMXMMMMXMSXAASXSMSMSMSSMMSMMXMAXMASASXSMSXAXAASAMXXSAAMASMXMASAMM
XAMAXMMXSXSASMMSSMAAMXMAASAMMMMSXMAAXAMMSMMMAXMXAAXAAXMAMASMMMMXMASXSXXSAXXAMXSXASAAMMMMMASAMASAAAMMAAMSSMMAMSXMAMSSXMMSMMASMMMMAMXMXAMAMASX
MAXSASXAMAMMSSMXAMMSSXMAMMAMXXAXAMSMSXXAMAXSXMASMSMSMMMXSASASAXASXMAMAMMASAAMAXSAMMSMMAAXAMAMAMMSSMSMSMAAAXSXSAMMMASASAXXSAMXSASMSAMSMSMSAMX
MMMMAXMMMAMASAXSAMAMMMMXSSSMMMMSMMAAMAMASMMMMMXXAMAMAMSAMMSASMSASAMAMAMXAMMSMAMSMSMXASMSMASXMAMMAMAXAAXSSMMMASMMXMASXMASAMSSMSASASAMSXAMMASX
SASMSMAAMXMXSAMSAMXXAAAMMAMMMAMAASMMMAAXMAMAAXMMXMASAMMASAMMMAXAMAMXSMSMSSXMMXXMAAASAMAAMAXXSXXMAMSMSMXMMMAMXMXMXMASAMAMAMMXMMXMMSAMMMSXSMMM
MASAXSSMXSMAMMMMXAXSSXXAMAMXSSSSMMAMSMSSSXSSSSMSASXSASMXMMSAMSMMSASASXAXAMAXMMMMSMXMSMSMSMSASAXSXMMMMMMSXSASXXAMSMMSAMXMXMMMSXSAXMAMAAXMMSAS
MSMMMMMSAAMXXAAMAMXXMAXSSMSMMMAMXMAMAMAAXAMXAXAMMSXSXMASXXMAAMAMSAMASXMMMMMMMAXAXXSAMXXAMAMAMXMMAMXAASAAASASAMASXAXMXXSXSMSAMAMXMSSMMMSAMMXM
SAAXXAAMSSMMSSSSSMXMMMMMAMXAMMSMASXSSSSMMSMMSMSMXMAXASAMMASAMMAMMAMAMAMAXAAMXXMASAMXMXMAMSMAMMMSAMXSSSMMMMXMMSMXXMMASMSAMAAXMSMAMAXAMAMAMAAM
ASMMSMXMAMXAAAAAMXAMAXASXMMSXAAMXSAAAAMXAXASXAAXMASXXMASMMMSMSMXSAMXXAMXMSMSASMMSAMXSXSXMXSAXAMSXMXMAMAMSMSSXAMMMSMMMAMSMAMSMAXAMMSMMAMXMSAS
MMMXXXXAASMSMMMMMMXSMSASAAAMMSMSAMMMMMMMSXMMMSMSMAMXMXXMAAAMMAAXMMXXXASAMMASMXAASXMXSAMAMAMMMSMMMSMMAMAAAAXASASAASAMMMAAXAMAMMSMMXAXMSSMXMAA
XMMXMASMXSAXMXMXSAMAAMXSXMXSAXAMMXXASXSAXAMXAAMAMXMAMMSMSMMXSMMMAMAXMMMMXSASXMMMMAMAMAMAMSSMAAAAAXXMASMSMMMMSXMAMSAMAMSSSXSXXXAXASMSMMAMAMXM
AMXMSAAXAMXMSXSASAXXXXXXMSMMMMAMSSMXSAMASAMSSMSXSASASAXAASMMSAXSSMSMXAAXAMXMAXSXSAMMSMSMSXAMSSSMSSXAMAMXAMSXMASXMSAMXMXAXASAMSAMXSXAMSAMAMMX
SAAMMSSMMSASXSMASMMSSMMSAMXAMSSMMAMAMXMASAMAXXAMSASASMMSMXSAMXMMAAAASXMMMSAMXMAASXSXAAAMMMAMXMMAXMAXSAMXSAXMAMXMASXMXXMMMMMAMMMMMMMAXMXMAMXM
MXMMAMXAXSXSXAMAMAXAAAAASMMAXAXXXAMXSXSASXMASXSMMAMAMXAAAXMMMAAXMMMMMAAMASXSMAMXMMMXMSMSAMMSMSMMMSAXSASAMMMSAMAAMMMMXMMMSMMMMMAAASXMMSMMAMAA
SAMMSMXAMXMMXAMASMMSXMXSMMMSMASMSMSASMMASMSAMXMAMSMMMMASAMXSMXSXSMXXXSMMASXMAXMXMAAAXMAMXSAAMMASAMXMSAMXSXAXAMSSXAASAAAASAAAAXMXMMAAAAMMSSXS
SAMMAASXMSAXSXXXAMAXXMMXASAAMAMMAXMASAMAMMXXMASAMAAAXMAMAXAXSAXMASXMAXAMXMAXXASXSMSSSMAMAMXXSSMMXSXMMMMMSMMSSXMXMSSXMMMXSAMSASXSSSSMMXXMXAMX
SAMMMMMAASMMXASMXMASAMXXAMSMMSXSXSMMMXMXSSSMSASMXSSMAMASMMSSMXXAMXMAMXAXSSSMMMAAXMAXXMAMMXSXAAXAXSMMAAAMXAAAMXAMMMAMMASAMXMMXXAAAMXXSMSXMASX
SMMXSASMMMAMMMMXAMAXAMXMSMMXAXAXAMXSAXXSMAMAMXMAAXAMXSXSXAMAXSMSXXXASMSMAAMXASMAMMMSSSXMSASMSMMMSMASXSSSSMMSSMMMAXMASASASMXXMMMMMMMAAAAXSAMM
SAMXSAXAASAMAMASXMASXSSXAASMMMXMASAMXSMMMAMSMAMMMXAMASASMSSMMSAMASMAMAAMMMMSASAAMAMMAMAAMAMAAAMMMMMMAAAMAASXMAXSMSXAMASAMAAXXAAAAAXXMXMMMASA
SAMXMAMSMSSXXMMAMXXMAAASMSMASAMSMMASMMXMAMMXMXSASXMMMMMXAXMAAMAMAMMSMSMMMAASXSXMMAXSAMXMMMMSSMMMAMXMXXSXSMMASMMMASXMMAMAMSMSMMMXXSSXMXSASAMX
SSMXMAMAAXAXSMSMSMMMMMMXMXMAMMMAAXXMAXMAASMSXMXXMASMSMXMSMXMMSAMXSAAAAXMXMXMAMXSSSXSASMSASAAAAMMAXXXMXMAMXMXMAMMAMAXMAXXMAMSASMSMAMXMAXMXMAS
SAXMMMSXSMMMXAAAAAASXSASMAMMMASXSMSSSMASMSAMASXMSMMAAMAMAMXXMXASMMMSSMXSAMXMSMAXAMASAMAAAMMSSMMSSSMASAMXMSSMSMMMASMMSASAMXXSAMAAMAMMMASMXSSM
SMMSAMXMMAXAMSMSMSMSASAMMXSASMSAXAXXXAXXAMMSAMMAAMMSMSXXAXXMSSMMAMMMAXAMAXMMMAMMMMMMAMMMMMAMXXMAMAAMMASMAAAAAAASXMXMXMAXMMASMMXMSMXSMASMAMAM
SXASMSAMSSMSAMAMAXAMXMAMAXSXSAMMMXMXMSMMMMAMASXMASAXXAASMSMAAXMASAASXMMSAMSASAMAAAXSAMASXMASMMAMMMMXMAMMMMMSMSMSAMXMAMAAXSASMSMXMMAXMXMMAXMM
XMAMXMAMAXAXMMAMXSAXXAMMMXMASASMSAAXAAXAXMXSMMAMMMXSXMAMAAMMMMXAASAMXAMMMMSASMMXMXXSASAMASXSAMMMASXMSSXXAXXXMMASAMAMAMXMMMAXAASAAMMSSMMSSSXS
SSMMSSSMMSXMASXMASAMSSMAXASASAMAMXXXSSSMXAMXXMMSAAAXAXMMSAMXSMMMMMSSMSAXAAMMMAASXMMSMMXSXMASMMASMSAMAMASMSMAMMMMSSMSMSAXMMSMSMSMSAAMAAXAASMS
AAAXAAXMAXAAXXAMXMAMAAXXMAMXMMMAMMMMAAAMMSASAMAMMSMMMMXAMASAMXAMXAAXXAMMMMXAMXAAAAMXMAXXAMAMASAMXSAMAMXMAAMAMAMMASMAASAMXAMXMAXAMMXSSMMMSMXX
SXMMMMMMMSSSXSXXXMAMMSMXAAMAAAXAXSAAXMAMAAMSAMASXMXAMXMAMAMASMSSMMSSSMXAAMSMSMSMSXMAMMMSMMASXMMSMMXMAMAXXMSSSMSMAXSMXMMMMAMAMMMMMAXMASASAMMS
MASAMXAXXAAXXAMXSMMMAAAXMASMXMSMSAMMMXMMSSMSAMXXAAMMSAXXMSSMMAMXMAMXMXAXMXAAXXXAXMMXSAAAASASMSMAASMSSSSMMXMXAAAMSMXXMASXXAMSMSAMMSMMASXSASAX
SAMASXMMMMSMSXMASAAMSSSMSMXMXXAMAMSXSAXAAAAXXAMSMMMXMASXXAAAMSSSSSSSSXSSSSMSXMMSMMSAMMMSMMASAAXMXMAAXSAASMXSMMMAMASXMXAAMMMXASXSAAMMXSMSMMXS
MXSAMMSAAXMAMXMAXAMXXAXAXXAMXMASAXAAMAMMSMMMSXMAMASXMASXMMSXMMAAXAAAXAXAAXMMAMMAASXSMAXXAMXMMMXSAMMMMSSMMMASXMXASMMAMXMMAAAMXMMMMSSMXSAMAMAS
MMMMSASXSMMAMMMMSSXSSMMMMMSMSSMMMMXMMAXMAXSAXAMMSASAMSMMAXAAMMMMMMMMMXMMSMASAMSMSMAMMXMXAMMMMSAMMXXMXMAXAMASASMMSXXAMAXXSMMSMMXSAMXMAMSMAMAS
AAAMMASXXASAMMAMXMAXAXAXSAAAAMSAXMMMSXSMXMMMSSMMMMXAMAAXSMMSMMASAMAXAMXXXMASXMAXAMXMSSSSSMAAAMAXSAMSMMMSMMASMMAMSMMMMXMMXMXXAMASAMXMMMAXSXMS
SMSSMSXMMAMAXSXSAMSMXMMMAXMXMMSMMSAMAMXMAMXMAMAXAMSSSMSMAMAAMMASASXMXAXSXMASASAXMAMXSAXAAXXMXXXMMASAAAAAAMAXMSSMMAASMMXSAMXSSMASMSMMMMMSMAAX
XAMXMMAMSSXMAAASMXAAASXSSSSXXXXAASXSSSMSSSMMASMMSAAAMAMXAMSSSMASAMXXASAMAMAMMMMSXAASMMMSMMSMSMAMSMMXSMSSSMSSXAXMMMMMAAAMASMAXMASAAAAAASAMAMS
MAMAMSMMAXAMXMXMASMSMSAXMAMMMSMMMSAXXAMXAAAMAMAAMMSMSMSSXXXAMMAMASAXMMASAMMMSAASMSMMAXAXMXAAASXMAXMAMMMAMAMAMMSMMSMSMMMSAMMMMMAMMMSMSXSAXSSM
AXSAMAMMMMXMMMMSMMXAAMMMMAMAAXAASMMMSMMMSMMMASMXMAMASAAMXMMMMMMSAMMMXSAMASXAXMXSAXAMXMMSSSMMMSXMMMMMMXMAMSMXMXAMXAAAAMXMMMAMXMSXXMAXXMMMMXAX
SASMSXSAAMSMMAASXSSMSMSXSXSMSSSMSAAMMAMMMMXSXSXXMMSAMMMMAMMXSAMMASXMAMMSXMMXSXMMMMMASMMAAAASXMAMAASXMASXMAMMXMAMSMSMMSAMSSSXMAMAAASAMXASXSSM
XXSXMMSMSMSAXMMXAAAAAAMXXMSAMAAAMXMMSAMMAMASAMAXSMMASXMXMSAASAMSAMAMASAAXSMXAXMAXSMAAAMMSMMMAAXMAMSAXXSASXSAAMXMSXMAAMXXAXMAMAMSMMMXSSSSXAXX
MMSAMASMMAMAMSMMSMMSMSMAXAMAMSMMMAMMSXMMAXAMAMMMSASAMXSAMMMXSAMMSSXMXSMMMAMMMXXAAXMAXXXAXMASMMMAMSMXMAMASAMMXSAMXAMMMSMSMSSXMAXAAASAMMMMMMMM
AAMXMASAMMMSMMAAXAXXAMAMXSMMMMXAMAXAXSSSSMSXMMMXSAMASAMMSXMMMXMAMMMSAMXXSAMAAMASXMSSMMMSSSMMMASXMAAAMXMSMAMAMSASMSMSXAAAXAAXSSSSSMSAMXAMAAAX
SSMAMAMMXSAXAMMMSMMMSMMXAXAXXXMMMSMMMMMAXAMXSAMMMMSXMASAMXSSXMMMSAAMAXXASMSMMSAMAMAAAAXAAXAXSASXSMSMSXMAMXMAXSAMAAAMAMXMMMMMAMXXMASAMXMXSSSX
AAXSMXMXXMASXMSXSXMAXAMMMSSMMAASAXASXAAAMXMAXASMAAAAMAMMSAAMSMAAMMMSAMSXMXAXMMASXMMSMMMMSMMMMASXMXXAMMXAMMSXMXMMSMSMXMAAAAXXXXAMXASXMASAMAMX
SSMMAMSMSMAMAMSAMXSASAMSMAMXASMSASAMXMMXMAMMSMXMMXSAMASXMMMMASMSSMAMAXMASXMSXSAMXSXXXAXXAAXXXMSAMAMASMSXMAXSXAMXXAXMASXSMSSSMMSSMXMASASAMAMM
MMAMXMAASMSXSMMAMAMXSXMXMASMXXAXAMAMXSAXSAMXAMSMMMXMXMXAXSXSAMSAXMXMXAXXMAAAXMASAASMSSSMMSMSAMXAMMSAMMAXASMMSXMAMMMMXAMXMXAAXAAAXSMMSMMMMMSS
MMMMSSMSMAXSMASXMXSASAASMXSAMMMMMMXXXAAXMMSSMXAAAAMAAMXMMMAMASAMXASXMMSSSMMMSXAXXAMXAASAAMASMASAMXMASMSMMXAMSMSXSASXSMSASASMMMSSMSAMMAXMSAAA
MAAAAXXMMAMAXXMXAAMASXMAXMXXMAXMSAMXSMMMMAAMMSSSMSSSMXAAAXSMMMMXXMASAAAAMMMXXMMSMXAMMSSSMMAMMMAAXAXXMAXXXSAMXASXSASXAASMSAAXMAMAASMXMSMAXMAS
SSSMMSSMMSSMMSMXMXMAMASXSSSMSSSXMASAXXSXMSSMAAMXAAAAAXSXMSMMSAXSASASMMMMMASASXAAASMSMAMAMMXMASMMMSMAMMMMMSXMASMAMMMMMMMAMMMMMMSMMMXMSMAMAXSM
XAAXXAMAAXAXAAXAMSMMSAMMAAAAAAMXSAMXSAMXAAAMMSXXMMXMMMMASAMAMASXXMASXSXXMAXMXMMXMAAAMAMAXXMMXMAMAXMASAAAMXMAMAMXMASAMMMMMMXAAMXXXMAMAASXMSAS
MSMMMASMMSMMSSSXSAAXMASAMSMMMXMAMXMAMXAMMMSMMAXXASXAMSSMMAMXMMSAMXXMASMMMSSMAMSSMXMMSSSXSAXXASAMXXSASMSSSMXMMSMXSASMSAAMAXSXMSASMSSSSSMAMAMX
AAXMAMMXMAXAXXMXAXXMMXMXMXMXMAMAMAMSSSXSAAXMMSSMAMXSXAAXSAMXSMMMSSMMXMSXAAAXASAAXSXXMAAASMMMXSXSAAMXSAMAAAASXXAAMMSXSXSSMXSASMAMAXMAMXMXMMXX
XSAMXMXSMMSMMMXXMAMMMXXAMAMASASASAMAAXAMMMMAAAAMAMMMMSSMSASXSAAAXMAMXXAMMSXMMMXSMMASMMMMMXSXMMMSXXXAMXMSMSMSASMMSXMASXMAMAMMMAMMSMMSAMXMXXXX
MXXMASASAMMMAMMMXSAASMSASASMSXSMSASMSMMMSMSMMSMSASXAAXAMXXMASMMMSSSMSSMSAMMSXAAMAMAMAXXXXAXAAAAXAXMXSAAXAXXMXMASXASAMASXMASAMXMAXXXMMMAMXMMM
MMSMXMASXMSMXSASAMSMAASASASASAMASAMAXXXXAAAXXMASASXMSSMSAAMXMASXMAAAMMXMAMASMMXSAMASXMSXMASXMMSMMXMASMSMSMXXASMMSXMAMXMAMXMXXSMXXSXMASAMXASX
AAAAAMXMMXSAASMMXMASMAMAMXMXMMMAMMMSMMMAMSMMAMXMAMAMXMASXXSASAMAMSMMMXMMAMMMAAAXASASAMXAMASASMXAXASAMAAAAXMXXMSAMXMSSMMSMMMSMMMMMSASASAXSAMX
MMSSXSMMSAMMMMMSMXMSXAMSMSMSMXMXSXAAAAXXXMMSSSMMXSAMXMXMMMSXMASAMAMSMAXSAMXSMMSSMMASMMASMASMMAMMXMMAXSMSMMMSMMMMSAMAAXAAMAAAAAAAXSAMAMXXMASX
SXMMASAXMMSMXAXXASMMXSSXAXAAMASMMMSSSMSXAXAAAAXSASASXMMAAAXMAMXMXMXAMAMSASXSXAMAXMMMASAXXXMMMSMSSMMSMXAMXSASAAAASAMXSMSSXMSSXSSSMMMMMMSXMMSA
XAASAMSXXXMXSMSMXMXAAXMMMMSMSASAXXAAXAMMMMMMMSMSASAMASMXMXSAMXXMASXMXSASAMAMMMSMMMXSAMMSMMSMXMAMAAAMAXXMXMAXSMMMSAMXXAXAAXAMAMAMAMXMSAMASAMM
SXMMAMMMMSXAMSAXASMXMMXAAXXAMMSXMMMXMXMAXAXMMXASXMAMAMMMSAMXMXMMAXAXXMAMAMAMSAAMASAMSSMAMMAMMMAMXMMSSMXAXMSMXMSAXMSSMMMSMMASXMAMASAXMASXMASX
AMSXSMAAAAMXSAMSXSAAMMMSMSMAMASASXXXAASASXSXAMAMAMXMAXAMXXMASAAMXSSMSMAMXSSXMSAXAMASAXXASXASXSMMXSAMAMMXSAMXAXMMMMSXASAMXMMMMSMSAMXSXAXASAMA
SASAXXSMSXAXAXMAAXXSAAAAXMMMMMSAMAMMSMMMAMMMXMAMAMXXMSMSMMSASMSMMXMAMSASAMXAMMXMASMMMMMMMMAMXAMXAMXSAMMMSAMMMSASXMXXAMXAAXAAXAAMMSMMMMSMMMSS
MAMAMAXAMXSASXMSSMMXAMSSSMSMMMMMMXMAAXMMMXAMAXSMSMSMAAMAAAMASAXXAAMAMMXSAMSMMAAXMMXAAAASXSASXSAMXSAMASAAXAMXAXAXMASMSSMSMSMSSSSMAAAXAMAMAXAA
MXMSMSMSAAXSMAXAAAXSSXAMMAAAAAMMSXMSSXMASMSSSXMAXASMSMSMMMSASASASMXMXSXMXMAMMMXAAASXMSAXXMAMAMMXMXMSMSMSSSMXMMSSMXMAMAMXXXXAXAMMXXXXMMMMXSSM
MXMXAXAMMMSASMMSSMMMMMXSMSMXMXXASAMXAMSSMAAAMAMXMXMAXAXXXXSAXAAMXMASAAAAMSXMAAMMMMSAMMMMMMSMMMMSMMXAMXAAAAAXXAAAAXMMSSMXXSMSSMXMSSSSMXSAMXAX
MXMMMMXMMXMMAMXAXAMXXMMMAMAMSSMMSAMMMMXAMXMAMMMXAXMXMXMMSMMMMMMXMSXMASXMAMMSMXSXAAMMXAAMMAAAASAAAXSMSMMMSMXSMMSSMMSAAXMXMMAAXXXMAAAXAAMAMXMX
SXMAMSMXXMMMSAMXSXMXAMXSMMAMAAAMMAMMXMSXMASMXAMXSAMASAXMAXAMXAXAXXAMAMXAXXAAXAXXMMMXXMMMMSMSMSXSMMXXAAAAXAAAMAMAAASMSMSAMMMMSSSMMSMMMMMAAAMM
AMMAMMXXASMAMXSXMASMMAAXMSXMSSMMSSMSAMXAMASAMXAMXMSASMSSMXXSSSSMASAMSSMSMMSSMMMAMXXSXXAXMMMMASAXMSSSXSMSSMMXMASMMMXAAMMAMXMASMAAAAXXXAXSSMSA
MSSMSAAMSMMMSMMASAMASAMXMMMMAAAXAMASXSXSMMSMAMAXAXMXSAXAMSMXMMAMMAMMMAAMXXAMXXAMXSMSASMMMAAMAMAXMAAMMMXMXMSXSASXSMMMMSSSMMMSSSSMMMXAMMXMAMAX
XMAMXMASXAAAAAXXMASXMMMAAXSSSMXSAMXMASAMAMXXMASMMXSAMXMAMAAAMSXMMMXAXAMXXMSMASXMMXAMAMAASMMSAMXMMMSMASAXMXMAMAMAAXMAXXAAAMSMMXXAXXMXXMAMAMMS
SMMMSXMAXXMMXMXSSMMASASXSMAAAXASAMXAASASMMSXMAMAMXMMSXSAMMSSXMASXXSXXSAMXSAMXXAAMXMMAMXMMAASAMXSMMMXAMAXXSMMMXMSMSXMXMXMMMMAMXSXMXMASMMSMSAS
MAAAXMAMAMSXSMXMAASMMAAAMMMMMMASAMXMAMAMAXXAMASAMMSXXAXAXXMAXSAMMXMASMAAXSMSXSSMMMASXSASMXMSAMAAAAAMMXSASAAXXMAMAAXAMSAMXMXAMMMSAXMXXAAXAMAM
SAMSSXXXMAMAAXAMMMMXMSMAMAAMXSASXXXXXXSSMMMXMASAMASAMXMMMSAMXXSXXAMXMSMSMMXAAXMASXMMASASAMASXMASMMSSMAMXAXMMMSAMXMXXAXMXASMXSAXXSXSMSMMMMMSM
MXAAMMMXMAMXMSXSXMASAMXXMXMSASAMXSMMMMMAMMSAMXSAMSXMXAXMAXXXMMMMSSSSXMXAAMMMMMSXMAXMAMASAMXMXMAXAAAXMXMSXXSXMASAXSMSSXMMMXAASXMXMXMAAXMXSAMX
MMMASXSSSSSSXAASXSAMASXSSMAMAXAMAMMAAAXXMASASASXMAMXSMSMSSXXMASASAAMMSMSXMAAAAXMMXMMXSASXMSSMXAXMMSMMSXMAXXAMXMMSXAAXAMASMMMMXMASAMXMSAXMASA
XASAMAMAAXAAMMSMAMXSAMAAAMAMMXMMXXASMMSAMXXMMMMXSSMXAAXXMXMXMSSSMMMMAXMMMMSSMSSSMSAXAMAMAAAAAMSSXAMAAXAMXMSSMMAXMMMMSXSAMAAMXSMMSASAAMMMMXMX
SXMMMAMMMMMMXSAMXMMMXMMSMMMSMXSASAAXAXMASAXSASXMAMASXAMXAAAXMAMMMMMMSSXSAXAXXAAAASXMMSSSMMMMMMMAMSSMMSSMXMAMASXXAAAXXMMMSSMSAAMAXAMMXMXASAMX
MMSASXSAMXMMXMXXXSXMXSAMXSAXAAMAMMXMMMSAMXMMASMMAXAAXAAMSMSMMASAAMAMXMASXMMSAMMMMMXSXAAAAMXMAXXAXXAAXAMXXMXXMSMSSSSSMXAMAXXMASMSSMMMMMSXXASX
AAXAMASMSMSMMMSSMMAMASAMXMMMMMSASXXMXAMXSSSMAMXSMMSSSMSMMMAASMSMSMSSMMAMAMAXMXSXXXSAMSSXMMXXAMSXMSXMMSSMMMSXXMAXAAXAXSSSMSMSXXAMXXAXAAMXSAMA
MMSAMXMXAAAXXAAAASXMASAMXXAAAASXSASAMXSXMAAMMMXAXAMAMXAAXSSXMMSXMAXXAMXSAMXXXASXMMXMAXMASMSMXXMAMAASAMAAAAXXAMXMMMMSMMXAXSAMXMAMXSSSXSAAMAMX
XXAXXXMSMSMSMMSSMMAMXXXAMXSMMMSMMAMSAMXAMXMMMSSMMMMMAXXMMXXXMASAMMMSMMXSMSMSMMMAXAAXMXMASAAXMASXMSSMASMMMSSXSMMXXXAAAXSXMMSMXSAMXMXSAMXXSAMM
XMASMAMMXMXXXAXXMSXSMSXMXAAMMAMAMXMXXMXAMAXAXAAASASXSSSSXMAXSXMMMAAAAAAMXMAAMXSMMSMMSASAMXMMSAMXXXAMXMXMSAMAXASXSMSSSMXASAMXMSXSMSAMXMSASASM
MXAXMAMMMSXMMMMMXXAAXMASMSSXMASXMMSXXMASXMSMSSSMMASAAAAXMXSXMAXAMXMMSMXXAMSMSMMSAAMAXXXASXMAMMSSXXMMSMAMMAMMXAMMAAMMXMSSMMSSMMXMAMAXSAMXSAMX
SXMSSMXSAAAAASASMMMMAMXMAAAASXMXMASXMASXAXAAMMMAMSMMMMMMAAXASMSMSXSAXXXXMXAMXMAASXMASMSMMAMXSXAXASAMXMASMXMXMSMMMXMMAMXMASAMAXSMASMMXXSAMXMX
SASAMXAMMXXMAMASMAAXSSSMSMSMMASXMASMAXMSMMMMMASAMAMSMMMSMMSAMAAXAAMMMXSAMSAMAMXMXXMAMXAMXXSSMMXSMAAMXSMSAASXMAAXXMASASMSMMMSMMAXAXXAMMMXSMSS
SXMASMMXXXSXSMAMMSSMMAMAAXMASAMAAXSMMMMXXAAASXXMMAXMAAAAAXMXMMMMMSMSAMXAMAASMSMSSXMXSSMMSMMAAMAMXAAXMSAMMMSASMXMSSMMAMMAXAAAXAMMSXSAAASXMMAS
SMSAMAXMSMMAMMXMAXXASAMMMMSAMMSMMMMXAAMSMXSMSAMXMMSMMMXXSMMASXSAXAAMSSMSMMXMAAAXMXSAAAXAAAMSXMXSMSSXAXXXXXSMMSAAAMXMSMSSMMSXSSXAMMSXSMSASMAM
SAMXSSMMSAMXMASMMSSXMAMXAMMASASMSMAXMSMAMMMAMMMAASAMXXSAMXSXSAASXMXMMXAXMAXMSMMMMAMMSMMSSMMMSMMXMAMMSMSMSMXSAXMMMSAMXASAAAAXSXMXSAMMXASAMMSS
MAMXAXMASMMMAMMAAXMMSAMSSMMAMXMAXMMSMAXXSAMAMAMSSMASAAMMMXMMMMMMMMMXMMSMAXXMXXMXMASAMXXMAASAMXAAMASMAXAAAXMMSSMSXSASXMMSMMSSMAMAMMMAMMMXMAMX
SAMMMXMAMAMMAMSMMSAAMAXMAAMSSSMSMMAAXMASMMSSMMXMAMAMMSMAMSASXSXAAAXMMAXXASMMAXAASXMASMSMSMMASMSXSAXXMMMSMMSAAMXMASMMAMXXXXXXMAMASXMXSXMSMSMM
XAXASXMASAMSAXAAMMMMSMMMMXMAAXAMAMSMSMMAMXAAXXASXMXSXAXAXSAMAMXMSMSASAMSXSASAMSASAMXXAXXMASAMXMAMMSMSAAAAAMMMSAMMMAMAMAMMASMXXSAXAMAMAAMAAMA
SMSMSASASAMSXSMSMXAAXAAXXSAMXMAMSMMAAXXMMMMSMSXSAMXMXMMMXMSMSMAMAMSXMAMAAMMMXXXAMMSSMMMMXMAMXAMAMSAASMSMMMSAXSXSMSSMASASXASASXMMSMMASAMMMMSS
AXAAXAMXSXMSAXMMMMMSSSMSAMAXMMXMAAMSMMXXAAMXAMXMAMASAXASAMXMAXMMAMMXSXMMMMASXSMSMAAXAAASAMMMMMXAMMMMMAAXXXMMXMXSXAXXXMAAMAMXAXSAAASASXXSAAXX
MSMSMXMXSMMMXMAMSASAMXAAASAMXSASMSMMXMSMSMSMSMSSMSASASASASXSMSXSXMXAMMMSXSAMAMAMMMMSSMXXASXMASMMSXMAMMMXSMMSXMASMMMMMMSMMASAMXMMSXMASXAXMXMX
XAXAAXMASAXAMMXAAMMSSMMSMMMMXSASAMXMAMAMMAMAXXMAMSXSXMASMMAAAAXAXSMSXSAAXMASAMAMASMMMSMSMMMMXSAAAASXSMXAAAAXAMASXXAAMAXXMASAXAXMMMMXMMMXMAAX
SSSMSXSAXXMMMSAMMXMAXAXMASXSMMAXXAAMSSSXSAMAMXSXMMAMXMXMXMSMMMSMSMAMAMMSSMXAMSASASASAMXAXAMSASMMMMMMAAMSSMMSAMXSMMMSMASXSMSMSMSMAAAAXAXAXXSA
MAMAMMMAXSAMASXXAAMXXSASMXAAXMAMMSXAAAMASASMMASMMMAMMMMSAMXMAMAXAMAMXMAXAXMAXAXXXSAMXSSMXMSMASASXXAMMMMXAXAAASAMASAAMXMASAMAMXAMMMXMMMMAASMX
MAMAMAMAMXAMASXMSXSMMMASXMSMMXXMMAAMMSMASMMAMAXAASASAASMMMXSAXSSSMSSSMSSSMSAMXMXMMMMXMXXAMAMXMASMSSSXXSXMMXXXMAMAMSSSSMMMAMAMMSSMSAMSSSMMXAX
SXMAXMMASXMMMXMAAAXAAMAMAXXAAAMSXMMSAXMASMSASMSSMSASMSMMXSAXMSMAAAXAMAMAMAXMAAMAAAAMSMSAMMAMXSAXMAXMAMSXSASMSSSMAMAMAAASMXMXSXAAAMASAAAXXMXM
SMSMSASAMAMAMSXXMSMMSSMSSMMSXXAAAAAMXXMXSASXMAXMASXXMMXXSMAXSAMMMMMAMXMAMMMMMSSMSSXSAAXASXSMMMASMMXSMMMXMASAAAMAXMASMXMMAAXAMMMMMSSMMSMASMMM
MAAAAAMMMASASAAMXMAXAAXAMXAXMASXSMMSMSMXMAMAMXMMMMMSXMASMMMMMASMMSMSMMSAMMASAMAXAAMMMXMAMAAMSMMMMMASAXSAMAMMMMSSMSMMXSMXXMMASAXXAXAAMAMAXXAX
MXMSMMMSSXMXXMXAAXXMSSMSSMMSSMXAMMMAAAAMMXMMSMAMMAAXAAXAMASXSMMAMSAAAASAMSAMASXMMSSMASAMMSMMXAXSAMMSAMMAMXSAMXAAAXXSAMSAAMSAXMSMMXMXSASMSSSS
XSXXXXAXMMSSSXSSSSMMXMAMAXMAASMMMMXMSMSAMXMAAXMMSMSSSMSMSASAAXMAMMMMMMSAMMASAMAAXAMXMMMSAMAXSMMSASAMAMSXMAXAMXSMMXXMAMXSSMMMSXAASAXMSXSAAXAA
MAAMAMXXAXAAAAAXMAMMAMMMAXMSMMXMASAMXMAXXAMXMMSAAXXAMAAXMASMMMSSSMSSSMXAMSMMMXSXMMSMSMXMASMMMAASXMMSMMAMMSSMMMXAMAMSSMAMXMASAMXMMASAMXMMMMMM
AMXSMMXSMMMSMMMMMAMXAMAMASXMAAMMASASAMXMSMSSXAMXSSMMMMMMSASASAXAAMAAMASAMXMAMMMASXMAAAASMMXAXSMSMMAMAXMXAAXAAASAMXAAXXXMASXMXSSSSXMXXMMAXASX
SXAAXMAAAAMAAAXAMSSSXSXSSMMSMMSMASAMXMAMXAAXMMMXXMAXAXSXMASXMAMMMMSSMMMXMASASMSAMMMMMSMMSASMMXAXAMAXMMXMMSXXMXSMASMSXMMMMMSMXAAXAXAXMMSAMXSS
MMXMAMSSSMSSSMXSXXAMAAXSAMAXAAXMAMXMASXMMMMXSAAMSSMMMXMAMXMASXMSXAAXAXMASMSASAMXMASXMMAAMMMMSMSMSSMSAMXAAMMSMMMXAXXMASASAAMXMMXMMMXSXAMXMMXX
MSMSMAAXAXMXMMSMMMAMXMXSAMSMMMMMAMXXAMAXXMAASAAXXAXMMASAMASAMAASMMSSMAXASAMXMAMXSAMXSSMMMSAAAAAAAAXSAMXMXSAXAAAMMSMXMMASMXMAXXASXSMAMXMSAMXM
SAAAAMMSMMSAMXAAASAMAXAXXMAMASASMSSMSSMMSMMXSMSXSAMXSASASMSAMMMMAMMAMAMSMMMXSXMMMXSMXASAAMMSSSMSMSMMAMAMMMASMMMMSAAAMSASASMSMMASAMAMSMAMXMSM
SMSMSMAAXAMASXSSMSASXMMSMSMSASXSAAMAMAXAAASAXAAXXMAMMASAMXSAMXAASMXAMASAAAMAMAAASAMXSAMMMSAAAAAXMAXSASASAMXMMAAXSMSMXAAXASAMXMAMAMSXXMASAXAX
XMAXXMMSMMSXMXMAXSXMXXXAXSXMXSXMMMMASXMASAMXMXMMAXSAMXMXMASAMSSSXASXSXSMSMMXSMMSMXSAMXMSAAMMSMMMXAASXSXSXSMMSMMMMXAXAMXMXMAMXMASAMAXXMASXSAS";
}